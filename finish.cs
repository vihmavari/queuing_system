using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_SMO
{
    public partial class finish : Form
    {
        public finish()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(1200, 600);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void finish_Load(object sender, EventArgs e)
        {
            build();
        }

        private void build()
        {
            if (Input.countClients != 1)
            {
                statTable.Rows.Add(Input.countClients - 1);
                statTable2.Rows.Add(Input.countRegisters - 1);
            }
            int i = 0;
            Statistics temp;
            Random rand = new Random();
            General.info.Add("CLIENTS\n=========================\n\n");

            foreach (DataGridViewRow row in statTable.Rows)
            {
                temp = Input.customersQueue[i].statistics;
                row.Cells["id"].Value = i;
                row.Cells["requests"].Value = temp.generatedRequestsCounter;

                switch (Input.lambda)
                {
                    default:
                        row.Cells["probability_of_refuse"].Value = (Convert.ToDouble(temp.refusedRequestsCounter) / temp.generatedRequestsCounter).ToString();
                        row.Cells["avg_time_in_system"].Value = (Convert.ToDouble(temp.totalTime) / temp.generatedRequestsCounter).ToString();
                        row.Cells["avg_time_in_buffer"].Value = (Convert.ToDouble(temp.totalBufferedTime) / temp.generatedRequestsCounter).ToString();
                        row.Cells["avg_time_on_device"].Value = (Convert.ToDouble(temp.totalInWorkTime) / temp.completedtedRequestsCounter).ToString();
                        break;
                }
                row.Cells["dispersion_buffer"].Value = temp.getBufferDispersion().ToString();
                row.Cells["dispersion_device"].Value = temp.getDeviceDispersion().ToString();
                General.info.Add("id = " + i.ToString());
                General.info.Add("requests = " + temp.generatedRequestsCounter.ToString());
                General.info.Add("probability_of_refuse = " + row.Cells["probability_of_refuse"].Value.ToString());
                General.info.Add("avg_time_in_system = " + row.Cells["avg_time_in_system"].Value.ToString());
                General.info.Add("avg_time_in_buffer = " + row.Cells["avg_time_in_buffer"].Value.ToString());
                General.info.Add("avg_time_on_device = " + row.Cells["avg_time_on_device"].Value.ToString());
                General.info.Add("dispersion_buffer = " + temp.getBufferDispersion().ToString());
                General.info.Add("dispersion_device = " + temp.getDeviceDispersion().ToString());


                if (Input.countClients != 1)
                {
                    i++;
                }                
            }
            i = 0;
            General.info.Add("DEVICES\n=========================\n\n");

            foreach (DataGridViewRow row in statTable2.Rows)
            {
                row.Cells["id2"].Value = i;
                row.Cells["usage_of_device"].Value = Input.cashRegisters[i].statTime / General.time;

                General.info.Add("id2 = " + i.ToString());
                General.info.Add("usage_of_device = " + row.Cells["usage_of_device"].Value.ToString());

                if (Input.countRegisters != 1)
                {
                    i++;
                }
            }

            foreach (DataGridViewRow row in statTable2.Rows)
            {
                if (Convert.ToDouble(row.Cells["usage_of_device"].Value) < 0.6)
                {
                    return;
                }
            }

            foreach (DataGridViewRow row in statTable.Rows)
            {
                if (Convert.ToDouble(row.Cells["probability_of_refuse"].Value) > 0.05)
                {
                    return;
                }
            }

            Console.WriteLine(General.info);
        }
    }
}
