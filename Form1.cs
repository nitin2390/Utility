using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Configuration;

namespace Utility
{
    public partial class Form1 : Form
    {
        Truck objTruck = new Truck();
        Truck objTruckOld = new Truck();
        ReadSerialPortData _readSerialPortData = new ReadSerialPortData();

        string filepath = ConfigurationManager.AppSettings["XMLPATH"].ToString();

        bool flagExport = true;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            objTruck = DeSerializeObject(filepath);
            txtTruckName.Text = objTruck.Name;
            dateTimePicker1.Text = objTruck.DateTime;
            txtFilePath.Text = objTruck.FilePath;
            txtWeight.Text = objTruck.Weight;
            if (txtDeliminator.Text =="" )
            {
                txtDeliminator.Text = ",";
            }
            else
            {
            txtDeliminator.Text = objTruck.Deliminator;
            }
            objTruckOld = objTruck;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Truck objTruck = new Truck();
            objTruck.Name = this.txtTruckName.Text;
            objTruck.DateTime = this.dateTimePicker1.Text;
            objTruck.FilePath = this.txtFilePath.Text;
            objTruck.Weight = this.txtWeight.Text;
            objTruck.Deliminator = this.txtDeliminator.Text;

            if (!(objTruck.Name == objTruckOld.Name &&
                objTruck.DateTime == objTruckOld.DateTime &&
                objTruck.FilePath == objTruckOld.FilePath &&
                objTruck.Weight == objTruckOld.Weight &&
                objTruck.Deliminator == objTruckOld.Deliminator 

                ))
            {
                if (SerializeObject(objTruck, filepath))
                {
                    if (flagExport == true)
                    {
                        MessageBox.Show("Data Saved!");
                        LoadData();
                    }
                    else
                    {
                        flagExport = true;
                    }
                }
            }
        }

        public bool SerializeObject(Truck serializableObject, string filepath)
        {

            if (serializableObject == null) { return false; }
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(filepath);
                    stream.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                //Log exception here
                return false;
            }
        }
        public Truck DeSerializeObject(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(Truck); }

            Truck objectOut = default(Truck);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(Truck);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (Truck)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return objectOut;
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog objSaveFileDialog;
            objSaveFileDialog = new SaveFileDialog();
            //objSaveFileDialog.ShowDialog();
            objSaveFileDialog.InitialDirectory = @"C:/";
            objSaveFileDialog.Title = "Truck Files";
            //objSaveFileDialog.CheckFileExists = true;
            objSaveFileDialog.CheckPathExists = true;
            objSaveFileDialog.DefaultExt = "txt";
            objSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (objSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = objSaveFileDialog.FileName;
            }



        }

        private void Export_Click(object sender, EventArgs e)
        {
            flagExport = false;
            Save_Click(null, null);
            using (TextWriter tw = File.CreateText(txtFilePath.Text))
            {
                tw.WriteLine(objTruck.Name + objTruck.Deliminator + 
                                objTruck.DateTime + objTruck.Deliminator +
                                    objTruck.Weight);
                MessageBox.Show("Data Exported!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            try
            {
                txtWeight.Text = btnWeight.Text = _readSerialPortData.ReadSerialPortCommunication().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
