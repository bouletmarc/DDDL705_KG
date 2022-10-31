using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

public class dddl : Form
{
    private IContainer icontainer_0;
    private ComboBox comboBox_0;
    private ComboBox comboBox_1;
    private TextBox textBox_0;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox pcid;
    private TextBox textBox_1;
    private Button button1;
    private Label label7;

    public dddl()
    {
        this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        byte num = 7;
        string text = this.pcid.Text;
        if ((this.pcid.Text != "00-00-00-00-00") && (text.Length == 14))
        {
            byte[] buffer = new byte[] { 0xff, 0xff, 0xff, 120, 0x67 };
            byte[] buffer2 = smethod_0(text.Replace("-", ""));
            buffer[0] = (byte) (buffer[0] ^ buffer[3]);
            buffer[1] = (byte) (buffer[1] ^ buffer[4]);
            buffer[2] = (byte) (buffer[2] ^ buffer[3]);
            int index = 0;
            while (true)
            {
                if (index >= 5)
                {
                    int num4 = 0;
                    while (true)
                    {
                        if (num4 >= 5)
                        {
                            int num5 = 0;
                            while (true)
                            {
                                if (num5 >= 5)
                                {
                                    string str2 = smethod_2(buffer, true);
                                    this.textBox_1.Text = str2;
                                    break;
                                }
                                buffer[num5] = (byte) (buffer[num5] ^ 0x69);
                                num5++;
                            }
                            break;
                        }
                        buffer[num4] = (byte) (buffer[num4] ^ num);
                        num4++;
                    }
                    break;
                }
                buffer[index] = (byte) (buffer[index] ^ buffer2[index]);
                index++;
            }
        }
    }

    private void dddl_Load(object sender, EventArgs e)
    {
        this.comboBox_0.SelectedIndex = 0;
        this.comboBox_1.SelectedIndex = 0;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager manager = new ComponentResourceManager(typeof(dddl));
        this.comboBox_0 = new ComboBox();
        this.comboBox_1 = new ComboBox();
        this.textBox_0 = new TextBox();
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.pcid = new TextBox();
        this.textBox_1 = new TextBox();
        this.button1 = new Button();
        this.label7 = new Label();
        base.SuspendLayout();
        this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_0.Enabled = false;
        this.comboBox_0.FormattingEnabled = true;
        object[] items = new object[] { "15", "14", "13", "12", "11", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
        this.comboBox_0.Items.AddRange(items);
        this.comboBox_0.Location = new Point(0x1d, 40);
        this.comboBox_0.Name = "rl";
        this.comboBox_0.Size = new Size(0x2e, 0x15);
        this.comboBox_0.TabIndex = 0;
        this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBox_1.Enabled = false;
        this.comboBox_1.FormattingEnabled = true;
        object[] objArray2 = new object[] { "15", "14", "13", "12", "11", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1" };
        this.comboBox_1.Items.AddRange(objArray2);
        this.comboBox_1.Location = new Point(0x53, 40);
        this.comboBox_1.Name = "wl";
        this.comboBox_1.Size = new Size(0x2e, 0x15);
        this.comboBox_1.TabIndex = 1;
        this.textBox_0.Enabled = false;
        this.textBox_0.Location = new Point(0x99, 0x29);
        this.textBox_0.Name = "tb1";
        this.textBox_0.Size = new Size(60, 20);
        this.textBox_0.TabIndex = 2;
        this.textBox_0.Text = "65535";
        this.label1.AutoSize = true;
        this.label1.Location = new Point(0x2a, 0x17);
        this.label1.Name = "label1";
        this.label1.Size = new Size(0x21, 13);
        this.label1.TabIndex = 3;
        this.label1.Text = "Read";
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0x54, 0x17);
        this.label2.Name = "label2";
        this.label2.Size = new Size(0x20, 13);
        this.label2.TabIndex = 4;
        this.label2.Text = "Write";
        this.label3.AutoSize = true;
        this.label3.Location = new Point(0x97, 0x17);
        this.label3.Name = "label3";
        this.label3.Size = new Size(0x3f, 13);
        this.label3.TabIndex = 5;
        this.label3.Text = "Expire Days";
        this.label4.AutoSize = true;
        this.label4.Location = new Point(0x49, 0x17);
        this.label4.Name = "label4";
        this.label4.Size = new Size(12, 13);
        this.label4.TabIndex = 6;
        this.label4.Text = "/";
        this.label5.AutoSize = true;
        this.label5.Location = new Point(0x1a, 0x41);
        this.label5.Name = "label5";
        this.label5.Size = new Size(0x42, 13);
        this.label5.TabIndex = 7;
        this.label5.Text = "Computer ID";
        this.label6.AutoSize = true;
        this.label6.Location = new Point(0x1a, 0x6a);
        this.label6.Name = "label6";
        this.label6.Size = new Size(70, 13);
        this.label6.TabIndex = 8;
        this.label6.Text = "Access Code";
        this.pcid.Location = new Point(0x1c, 0x52);
        this.pcid.Name = "pcid";
        this.pcid.Size = new Size(100, 20);
        this.pcid.TabIndex = 9;
        this.pcid.Text = "00-00-00-00-00";
        this.textBox_1.Location = new Point(0x1c, 0x7a);
        this.textBox_1.Name = "tb2";
        this.textBox_1.ReadOnly = true;
        this.textBox_1.Size = new Size(100, 20);
        this.textBox_1.TabIndex = 10;
        this.button1.Location = new Point(0x9a, 0x52);
        this.button1.Name = "button1";
        this.button1.Size = new Size(60, 60);
        this.button1.TabIndex = 11;
        this.button1.Text = "Generate";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new EventHandler(this.button1_Click);
        this.label7.AutoSize = true;
        this.label7.ForeColor = Color.Silver;
        this.label7.Location = new Point(140, 150);
        this.label7.Name = "label7";
        this.label7.Size = new Size(0x5d, 13);
        this.label7.TabIndex = 12;
        this.label7.Text = "Coded by C#4v32";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0xf4, 0xac);
        base.Controls.Add(this.label7);
        base.Controls.Add(this.button1);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.pcid);
        base.Controls.Add(this.label6);
        base.Controls.Add(this.label5);
        base.Controls.Add(this.label4);
        base.Controls.Add(this.label3);
        base.Controls.Add(this.label2);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.comboBox_1);
        base.Controls.Add(this.comboBox_0);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon) manager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.Name = "dddl";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "DDDL 7.0x";
        base.Load += new EventHandler(this.dddl_Load);
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    public static byte[] smethod_0(string string_0)
    {
        string_0 = string_0.Replace("-", "");
        int num = string_0.Length / 2;
        byte[] buffer = new byte[num];
        for (int i = 0; i < num; i++)
        {
            buffer[i] = byte.Parse(string_0.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        }
        return buffer;
    }

    public static string smethod_1(byte[] byte_0) => 
        smethod_2(byte_0, false);

    public static string smethod_2(byte[] byte_0, bool bool_0)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < byte_0.Length; i++)
        {
            object[] args = new object[] { byte_0[i] };
            builder.Append(string.Format(CultureInfo.InvariantCulture, "{0:X2}", args));
            if (bool_0 && (i < (byte_0.Length - 1)))
            {
                builder.Append("-");
            }
        }
        return builder.ToString();
    }
}

