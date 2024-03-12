
namespace ModdusTCP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ip_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this._disconnect = new System.Windows.Forms.Button();
            this._cpanel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p_sensor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._temp = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.req_timer = new System.Windows.Forms.Timer(this.components);
            this._status = new System.Windows.Forms.Label();
            this._cpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ip_box
            // 
            this.Ip_box.Location = new System.Drawing.Point(34, 22);
            this.Ip_box.Name = "Ip_box";
            this.Ip_box.Size = new System.Drawing.Size(118, 22);
            this.Ip_box.TabIndex = 3;
            this.Ip_box.Text = "192.168.0.198";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(159, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port:";
            // 
            // port_box
            // 
            this.port_box.Location = new System.Drawing.Point(198, 22);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(68, 22);
            this.port_box.TabIndex = 6;
            this.port_box.Text = "502";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(70, 424);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 17);
            this.status_label.TabIndex = 10;
            // 
            // _disconnect
            // 
            this._disconnect.Location = new System.Drawing.Point(272, 31);
            this._disconnect.Name = "_disconnect";
            this._disconnect.Size = new System.Drawing.Size(95, 23);
            this._disconnect.TabIndex = 11;
            this._disconnect.Text = "Disconnect";
            this._disconnect.UseVisualStyleBackColor = true;
            this._disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // _cpanel
            // 
            this._cpanel.Controls.Add(this.label6);
            this._cpanel.Controls.Add(this.p_sensor);
            this._cpanel.Controls.Add(this.label5);
            this._cpanel.Controls.Add(this._temp);
            this._cpanel.Controls.Add(this.button9);
            this._cpanel.Controls.Add(this.button10);
            this._cpanel.Controls.Add(this.button7);
            this._cpanel.Controls.Add(this.button8);
            this._cpanel.Controls.Add(this.button5);
            this._cpanel.Controls.Add(this.button6);
            this._cpanel.Controls.Add(this.button4);
            this._cpanel.Controls.Add(this.button2);
            this._cpanel.Location = new System.Drawing.Point(7, 60);
            this._cpanel.Name = "_cpanel";
            this._cpanel.Size = new System.Drawing.Size(360, 303);
            this._cpanel.TabIndex = 13;
            this._cpanel.TabStop = false;
            this._cpanel.Text = "Control Panel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sensor :";
            // 
            // p_sensor
            // 
            this.p_sensor.AutoSize = true;
            this.p_sensor.Location = new System.Drawing.Point(187, 224);
            this.p_sensor.Name = "p_sensor";
            this.p_sensor.Size = new System.Drawing.Size(32, 17);
            this.p_sensor.TabIndex = 10;
            this.p_sensor.Text = "Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temp :";
            // 
            // _temp
            // 
            this._temp.AutoSize = true;
            this._temp.Location = new System.Drawing.Point(187, 207);
            this._temp.Name = "_temp";
            this._temp.Size = new System.Drawing.Size(32, 17);
            this._temp.TabIndex = 8;
            this._temp.Text = "Null";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(196, 172);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 32);
            this.button9.TabIndex = 7;
            this.button9.Text = "Off(Rel4)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(115, 172);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 32);
            this.button10.TabIndex = 6;
            this.button10.Text = "On(Rel4)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(196, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 32);
            this.button7.TabIndex = 5;
            this.button7.Text = "Off(Rel3)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(115, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 4;
            this.button8.Text = "On(Rel3)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(196, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 3;
            this.button5.Text = "Off(Rel2)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(115, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 2;
            this.button6.Text = "On(Rel2)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "Off(Rel1)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "On(Rel1)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // req_timer
            // 
            this.req_timer.Tick += new System.EventHandler(this.req_timer_Tick);
            // 
            // _status
            // 
            this._status.AutoSize = true;
            this._status.Location = new System.Drawing.Point(70, 375);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(0, 17);
            this._status.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 401);
            this.Controls.Add(this._status);
            this.Controls.Add(this._cpanel);
            this.Controls.Add(this._disconnect);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ip_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._cpanel.ResumeLayout(false);
            this._cpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Ip_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Button _disconnect;
        private System.Windows.Forms.GroupBox _cpanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label p_sensor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _temp;
        private System.Windows.Forms.Timer req_timer;
        private System.Windows.Forms.Label _status;
    }
}

