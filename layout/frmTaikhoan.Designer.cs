
namespace layout
{
    partial class frmTaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaikhoan));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.cbquyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatkhau = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenTk = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.txtID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDstaikhoan = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTTNhanvien = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDstaikhoan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 20;
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.DisabledState.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Location = new System.Drawing.Point(380, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(180, 45);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbquyen
            // 
            this.cbquyen.BackColor = System.Drawing.Color.Transparent;
            this.cbquyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbquyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbquyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbquyen.FocusedState.Parent = this.cbquyen;
            this.cbquyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbquyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbquyen.HoverState.Parent = this.cbquyen;
            this.cbquyen.ItemHeight = 30;
            this.cbquyen.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbquyen.ItemsAppearance.Parent = this.cbquyen;
            this.cbquyen.Location = new System.Drawing.Point(300, 159);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.ShadowDecoration.Parent = this.cbquyen;
            this.cbquyen.Size = new System.Drawing.Size(260, 36);
            this.cbquyen.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Quyền";
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 20;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(175, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThemtaikhoan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.AcceptsReturn = false;
            this.txtMatkhau.AcceptsTab = false;
            this.txtMatkhau.AnimationSpeed = 200;
            this.txtMatkhau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatkhau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatkhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMatkhau.BackgroundImage")));
            this.txtMatkhau.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMatkhau.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMatkhau.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMatkhau.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMatkhau.BorderRadius = 1;
            this.txtMatkhau.BorderThickness = 1;
            this.txtMatkhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.FillColor = System.Drawing.Color.White;
            this.txtMatkhau.HideSelection = true;
            this.txtMatkhau.IconLeft = null;
            this.txtMatkhau.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.IconPadding = 10;
            this.txtMatkhau.IconRight = null;
            this.txtMatkhau.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.Lines = new string[0];
            this.txtMatkhau.Location = new System.Drawing.Point(300, 110);
            this.txtMatkhau.MaxLength = 32767;
            this.txtMatkhau.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMatkhau.Modified = false;
            this.txtMatkhau.Multiline = false;
            this.txtMatkhau.Name = "txtMatkhau";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatkhau.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMatkhau.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatkhau.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMatkhau.OnIdleState = stateProperties4;
            this.txtMatkhau.Padding = new System.Windows.Forms.Padding(3);
            this.txtMatkhau.PasswordChar = '\0';
            this.txtMatkhau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatkhau.PlaceholderText = "Enter text";
            this.txtMatkhau.ReadOnly = false;
            this.txtMatkhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.SelectionLength = 0;
            this.txtMatkhau.SelectionStart = 0;
            this.txtMatkhau.ShortcutsEnabled = true;
            this.txtMatkhau.Size = new System.Drawing.Size(260, 38);
            this.txtMatkhau.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMatkhau.TabIndex = 42;
            this.txtMatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatkhau.TextMarginBottom = 0;
            this.txtMatkhau.TextMarginLeft = 3;
            this.txtMatkhau.TextMarginTop = 0;
            this.txtMatkhau.TextPlaceholder = "Enter text";
            this.txtMatkhau.UseSystemPasswordChar = false;
            this.txtMatkhau.WordWrap = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(164, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 41;
            this.label11.Text = "Tên tài khoản";
            // 
            // txtTenTk
            // 
            this.txtTenTk.AcceptsReturn = false;
            this.txtTenTk.AcceptsTab = false;
            this.txtTenTk.AnimationSpeed = 200;
            this.txtTenTk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenTk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenTk.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTenTk.BackgroundImage")));
            this.txtTenTk.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTenTk.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTenTk.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTenTk.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTenTk.BorderRadius = 1;
            this.txtTenTk.BorderThickness = 1;
            this.txtTenTk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenTk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTk.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTk.DefaultText = "";
            this.txtTenTk.FillColor = System.Drawing.Color.White;
            this.txtTenTk.HideSelection = true;
            this.txtTenTk.IconLeft = null;
            this.txtTenTk.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTk.IconPadding = 10;
            this.txtTenTk.IconRight = null;
            this.txtTenTk.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTk.Lines = new string[0];
            this.txtTenTk.Location = new System.Drawing.Point(300, 66);
            this.txtTenTk.MaxLength = 32767;
            this.txtTenTk.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTenTk.Modified = false;
            this.txtTenTk.Multiline = false;
            this.txtTenTk.Name = "txtTenTk";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenTk.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenTk.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenTk.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenTk.OnIdleState = stateProperties8;
            this.txtTenTk.Padding = new System.Windows.Forms.Padding(3);
            this.txtTenTk.PasswordChar = '\0';
            this.txtTenTk.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenTk.PlaceholderText = "Enter text";
            this.txtTenTk.ReadOnly = false;
            this.txtTenTk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenTk.SelectedText = "";
            this.txtTenTk.SelectionLength = 0;
            this.txtTenTk.SelectionStart = 0;
            this.txtTenTk.ShortcutsEnabled = true;
            this.txtTenTk.Size = new System.Drawing.Size(260, 38);
            this.txtTenTk.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTenTk.TabIndex = 40;
            this.txtTenTk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTk.TextMarginBottom = 0;
            this.txtTenTk.TextMarginLeft = 3;
            this.txtTenTk.TextMarginTop = 0;
            this.txtTenTk.TextPlaceholder = "Enter text";
            this.txtTenTk.UseSystemPasswordChar = false;
            this.txtTenTk.WordWrap = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Quyền: 1. Quản trị, 2. Nhân viên kho, 3. Nhân viên bán hàng\r\n\r\n";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(380, 268);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BorderRadius = 20;
            this.btnCapnhat.CheckedState.Parent = this.btnCapnhat;
            this.btnCapnhat.CustomImages.Parent = this.btnCapnhat;
            this.btnCapnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapnhat.DisabledState.Parent = this.btnCapnhat;
            this.btnCapnhat.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.HoverState.Parent = this.btnCapnhat;
            this.btnCapnhat.Location = new System.Drawing.Point(175, 268);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.ShadowDecoration.Parent = this.btnCapnhat;
            this.btnCapnhat.Size = new System.Drawing.Size(180, 45);
            this.btnCapnhat.TabIndex = 49;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(300, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(260, 23);
            this.txtID.TabIndex = 51;
            this.txtID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mã tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDstaikhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 300);
            this.panel1.TabIndex = 53;
            // 
            // dgvDstaikhoan
            // 
            this.dgvDstaikhoan.AllowCustomTheming = false;
            this.dgvDstaikhoan.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDstaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDstaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDstaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDstaikhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDstaikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDstaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDstaikhoan.ColumnHeadersHeight = 40;
            this.dgvDstaikhoan.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDstaikhoan.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDstaikhoan.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDstaikhoan.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDstaikhoan.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDstaikhoan.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDstaikhoan.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDstaikhoan.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDstaikhoan.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDstaikhoan.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDstaikhoan.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDstaikhoan.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDstaikhoan.CurrentTheme.Name = null;
            this.dgvDstaikhoan.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDstaikhoan.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDstaikhoan.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDstaikhoan.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDstaikhoan.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDstaikhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDstaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDstaikhoan.EnableHeadersVisualStyles = false;
            this.dgvDstaikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDstaikhoan.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDstaikhoan.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDstaikhoan.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDstaikhoan.Location = new System.Drawing.Point(0, 0);
            this.dgvDstaikhoan.Name = "dgvDstaikhoan";
            this.dgvDstaikhoan.RowHeadersVisible = false;
            this.dgvDstaikhoan.RowTemplate.Height = 40;
            this.dgvDstaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDstaikhoan.Size = new System.Drawing.Size(1251, 300);
            this.dgvDstaikhoan.TabIndex = 0;
            this.dgvDstaikhoan.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvDstaikhoan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDstaikhoan_CellMouseClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTTNhanvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(739, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 406);
            this.panel2.TabIndex = 54;
            // 
            // dgvTTNhanvien
            // 
            this.dgvTTNhanvien.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTTNhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTTNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTTNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTTNhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTTNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNhanvien.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTTNhanvien.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTTNhanvien.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTTNhanvien.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTTNhanvien.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTTNhanvien.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTTNhanvien.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTTNhanvien.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTTNhanvien.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTTNhanvien.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTTNhanvien.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTTNhanvien.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTTNhanvien.CurrentTheme.Name = null;
            this.dgvTTNhanvien.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTTNhanvien.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTTNhanvien.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTTNhanvien.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTTNhanvien.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTNhanvien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTTNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTNhanvien.EnableHeadersVisualStyles = false;
            this.dgvTTNhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTTNhanvien.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTTNhanvien.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTTNhanvien.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTTNhanvien.Location = new System.Drawing.Point(0, 0);
            this.dgvTTNhanvien.Name = "dgvTTNhanvien";
            this.dgvTTNhanvien.RowHeadersVisible = false;
            this.dgvTTNhanvien.RowTemplate.Height = 40;
            this.dgvTTNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTNhanvien.Size = new System.Drawing.Size(512, 406);
            this.dgvTTNhanvien.TabIndex = 0;
            this.dgvTTNhanvien.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvTTNhanvien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTTNhanvien_CellMouseClick);
            // 
            // frmTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbquyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTenTk);
            this.Name = "frmTaikhoan";
            this.Text = "frmTaikhoan";
            this.Load += new System.EventHandler(this.frmTaikhoan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDstaikhoan)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2ComboBox cbquyen;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuTextBox txtMatkhau;
        private System.Windows.Forms.Label label11;
        private Bunifu.UI.WinForms.BunifuTextBox txtTenTk;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDstaikhoan;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTTNhanvien;
    }
}