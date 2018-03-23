using OpenTibia.Client;
using OpenTibia.Client.Things;
using OpenTibia.Core;
using OpenTibia.Obd;
using OpenTibia.Utils;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace OBDExporter
{
    public partial class MainForm : Form
    {
        #region | Private Properties |

        private VersionStorage m_versions;
        private ClientImpl m_client;
        private BackgroundWorker m_worker;
        private ObdVersion m_obdVersion;

        #endregion

        #region | Constructor |

        public MainForm()
        {
            m_versions = new VersionStorage();
            m_client = new ClientImpl();
            m_client.ClientLoaded += new EventHandler(ClientLoaded_Handler);
            m_client.ProgressChanged += new ProgressHandler(ClientProgressChanged_Handler);
            m_worker = new BackgroundWorker();
            m_worker.WorkerReportsProgress = true;
            m_worker.DoWork += new DoWorkEventHandler(DoWork_Handler);
            m_worker.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged_Handler);
            m_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompleted_Handler);

            InitializeComponent();
            LoadVersions();

            obdVersionComboBox.Items.Add(ObdVersion.Version1);
            obdVersionComboBox.Items.Add(ObdVersion.Version2);
            obdVersionComboBox.SelectedIndex = 0;
            itemsListBox.Client = m_client;
            outfitsListBox.Client = m_client;
            effectsListBox.Client = m_client;
            missilesListBox.Client = m_client;
            thingTypeListBox.Client = m_client;
            saveButton.Enabled = false;
        }

        #endregion

        #region | Private Methods |

        private void LoadVersions()
        {
            m_versions.Load(@"versions.xml");
            versionsComboBox.Items.AddRange(m_versions.GetAllVersions());
            versionsComboBox.SelectedIndex = 0;
        }

        private void LoadClient()
        {
            if (m_client.Loaded)
            {
                return;
            }

            string directory = Path.Combine(PathUtils.ApplicationDirectory, "Input");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string datPath = Path.Combine(directory, "Tibia.dat");
            string sprPath = Path.Combine(directory, "Tibia.spr");

            try
            {
                OpenTibia.Core.Version version = versionsComboBox.SelectedItem as OpenTibia.Core.Version;
                m_client.Load(datPath, sprPath, version);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            itemsListBox.AddRange(m_client.GetAllItems());
            outfitsListBox.AddRange(m_client.GetAllOutfits());
            effectsListBox.AddRange(m_client.GetAllEffects());
            missilesListBox.AddRange(m_client.GetAllMissiles());
        }

        #endregion

        #region Private Methods

        private ListBox.SelectedObjectCollection GetSelectedThings()
        {
            if (m_client.Loaded)
            {
                switch (objectsTabControl.SelectedIndex)
                {
                    case 0:
                        return itemsListBox.SelectedItems;

                    case 1:
                        return outfitsListBox.SelectedItems;

                    case 2:
                        return effectsListBox.SelectedItems;

                    case 3:
                        return missilesListBox.SelectedItems;
                }
            }

            return null;
        }

        #endregion

        #region | Event Handlers |

        protected override void OnLoad(EventArgs args)
        {
            base.OnLoad(args);

            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string version = FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
                Text = "OBDExporter " + version.Substring(0, version.LastIndexOf("."));
            }
            catch
            {
                Text = "OBDExporter";
            }
        }

        private void ClientLoaded_Handler(object sender, EventArgs args)
        {
            loadButton.Enabled = false;
            progressBar.Value = 0;
        }

        private void ClientProgressChanged_Handler(object sender, int percentage)
        {
            progressBar.Value = percentage;
        }

        private void ObdVersionComboBox_SelectedIndexChanged(object sender, EventArgs args)
        {
            m_obdVersion = (ObdVersion)obdVersionComboBox.SelectedItem;
        }

        private void LoadButton_Click(object sender, EventArgs args)
        {
            LoadClient();
        }

        private void SaveButton_Click(object sender, EventArgs args)
        {
            if (this.thingTypeListBox.Items.Count != 0)
            {
                saveButton.Enabled = false;
                addButton.Enabled = false;
                removeButton.Enabled = false;
                m_worker.RunWorkerAsync();
            }
        }

        private void AddButton_Click(object sender, EventArgs args)
        {
            ListBox.SelectedObjectCollection list = this.GetSelectedThings();
            if (list == null)
            {
                return;
            }

            foreach (ThingType thing in list)
            {
                if (!thingTypeListBox.Items.Contains(thing))
                {
                    thingTypeListBox.Items.Add(thing);
                }
            }

            saveButton.Enabled = this.thingTypeListBox.Items.Count > 0;
        }

        private void RemoveButton_Click(object sender, EventArgs args)
        {
            thingTypeListBox.RemoveSelectedThings();
        }

        private void ClearButton_Click(object sender, EventArgs args)
        {
            thingTypeListBox.Clear();
        }

        private void DoWork_Handler(object sender, DoWorkEventArgs args)
        {
            string directory = Path.Combine(PathUtils.ApplicationDirectory, "Output");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            int count = 0;

            foreach (ThingType thing in thingTypeListBox.Items)
            {
                ObjectData data = m_client.GetThingData(thing.ID, thing.Category, true);
                string path = Path.Combine(directory, thing.Category + "_" + thing.ID + ".obd");

                using (FileStream writer = new FileStream(path, FileMode.Create))
                {
                    byte[] bytes = ObdEncoder.Encode(data, m_obdVersion);
                    writer.Write(bytes, 0, bytes.Length);
                }

                Thread.Sleep(5);
                m_worker.ReportProgress(((++count * 100) / thingTypeListBox.Items.Count));
            }
        }

        private void ProgressChanged_Handler(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void RunWorkerCompleted_Handler(object sender, RunWorkerCompletedEventArgs e)
        {
            saveButton.Enabled = true;
            addButton.Enabled = true;
            removeButton.Enabled = true;
            progressBar.Value = 0;
        }

        #endregion
    }
}
