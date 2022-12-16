using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CW_SMO
{
    public partial class step_mode : Form
    {
        Event myEvent = null;
        Controller controller;
        int pointer;

        public step_mode()
        {
            controller = new Controller();

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(1200, 600);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void step_mode_Load(object sender, EventArgs e)
        {
            build();
        }

        private void build()
        {
            countDevicesLabel.Text = "И" + Input.countClients.ToString();
            bufferTable.Rows.Add(Input.bufferSize - 1);

            int i = 0;
            foreach (DataGridViewRow row in bufferTable.Rows)
            {
                row.Cells["id"].Value = i;
                
                i++;
            }
            devicesTable.Rows.Add(Input.countRegisters - 1);
            i = 0;
            foreach (DataGridViewRow row in devicesTable.Rows)
            {
                row.Cells["id2"].Value = i;
                row.Cells["request2"].Value = "free";
                i++;
            }
            devicesTable.Rows[0].Cells["ptr"].Value = "←";
            pointer = 0;
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            if (Input.events.Count == 0)
            {
                finish finishForm = new finish();
                finishForm.FormClosing += delegate { this.Show(); };
                Hide();
                finishForm.ShowDialog();
                return;
            }

            myEvent = controller.stepMode();

            switch (myEvent.type)
            {
                case Type.GENERATION:
                    requestLabel.ForeColor = Color.Black;
                    requestLabel.Text = General.lastGeneratedInfo;
                    break;
                
                case Type.INSERTION:
                    int i = 0;
                    foreach (DataGridViewRow row in bufferTable.Rows)
                    {
                        if (Input.buffer[i].GetOrder() != -1)
                        {
                            row.Cells["request"].Value = Input.buffer[i].GetInfo();
                            row.Cells["order"].Value = Input.buffer[i].GetOrder();
                            if (Input.buffer[i].IsInPackage())
                            {
                                row.Cells["pack"].Value = "+";
                            }
                            else
                            {
                                row.Cells["pack"].Value = "";
                            }
                        }
                        i++;
                    }
                    requestLabel.ForeColor = Color.Red;
                    requestLabel.Text = General.lastDeletedInfo;
                    break;
                
                case Type.EXTRACTION:
                    General.lastDeletedInfo = "---";
                    requestLabel.Text = General.lastDeletedInfo;

                    int d = 0;
                    foreach (DataGridViewRow row in bufferTable.Rows)
                    {
                        if (Input.buffer[d].GetOrder() != -1)
                        {
                            row.Cells["request"].Value = Input.buffer[d].GetInfo();
                            row.Cells["order"].Value = Input.buffer[d].GetOrder();
                            if (Input.buffer[d].IsInPackage())
                            {
                                row.Cells["pack"].Value = "+";
                            }
                            else
                            {
                                row.Cells["pack"].Value = "";
                            }
                        }
                        d++;
                    }

                    if (myEvent.request != null)
                    {
                        Request extractionRequest = myEvent.request;
                        bufferTable.Rows[extractionRequest.GetId()].Cells["request"].Value = "";
                        bufferTable.Rows[extractionRequest.GetId()].Cells["order"].Value = "";
                        bufferTable.Rows[extractionRequest.GetId()].Cells["pack"].Value = "";
                        devicesTable.Rows[myEvent.deviceId].Cells["request2"].Value = extractionRequest.GetInfo();
                        

                    }
                    foreach(DataGridViewRow row in devicesTable.Rows)
                    {
                        row.Cells["ptr"].Value = "";
                    }
                    if (myEvent.deviceId != -1)
                    {
                        devicesTable.Rows[myEvent.deviceId].Cells["ptr"].Value = "←";
                        pointer = myEvent.deviceId;
                    }
                    else
                    {
                        devicesTable.Rows[pointer].Cells["ptr"].Value = "←";
                    }
                    requestLabel.ForeColor = Color.Black;
                    break;
                
                case Type.RELEASE:
                    int j = 0;
                    foreach (DataGridViewRow row in bufferTable.Rows)
                    {
                        if (Input.buffer[j].GetOrder() != -1)
                        {
                            row.Cells["request"].Value = Input.buffer[j].GetInfo();
                            row.Cells["order"].Value = Input.buffer[j].GetOrder();
                            if (Input.buffer[j].IsInPackage())
                            {
                                row.Cells["pack"].Value = "+";
                            }
                            else
                            {
                                row.Cells["pack"].Value = "";
                            }
                        }
                        j++;
                    }
                    j = 0;
                    foreach (DataGridViewRow row in devicesTable.Rows)
                    {
                        if (Input.cashRegisters[j].GetRequest() != null)
                        {
                            row.Cells["request2"].Value = Input.cashRegisters[j].GetRequest().GetInfo();
                        }
                        else
                        {
                            row.Cells["request2"].Value = "free";
                        }
                        j++;
                    }
                    break;
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            controller.autoMode();

            finish finishForm = new finish();
            finishForm.FormClosing += delegate { this.Show(); };
            Hide();
            finishForm.ShowDialog();
        }
    }
}
