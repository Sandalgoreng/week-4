namespace W4_Homework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_list = new System.Windows.Forms.Label();
            this.lab_add_team = new System.Windows.Forms.Label();
            this.lab_add_teamm = new System.Windows.Forms.Label();
            this.lab_coun = new System.Windows.Forms.Label();
            this.lab_team = new System.Windows.Forms.Label();
            this.lab_nameTeam = new System.Windows.Forms.Label();
            this.lab_country = new System.Windows.Forms.Label();
            this.lab_city = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_pos = new System.Windows.Forms.Label();
            this.but_addTeam = new System.Windows.Forms.Button();
            this.but_addPlayer = new System.Windows.Forms.Button();
            this.cbox_coun = new System.Windows.Forms.ComboBox();
            this.cbox_team = new System.Windows.Forms.ComboBox();
            this.output_players = new System.Windows.Forms.ListBox();
            this.but_remove = new System.Windows.Forms.Button();
            this.tbox_tname = new System.Windows.Forms.TextBox();
            this.tbox_tcoun = new System.Windows.Forms.TextBox();
            this.tbox_tcity = new System.Windows.Forms.TextBox();
            this.tbox_pname = new System.Windows.Forms.TextBox();
            this.tbox_pnum = new System.Windows.Forms.TextBox();
            this.cbox_ppos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lab_list
            // 
            this.lab_list.AutoSize = true;
            this.lab_list.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_list.Location = new System.Drawing.Point(557, 150);
            this.lab_list.Name = "lab_list";
            this.lab_list.Size = new System.Drawing.Size(129, 20);
            this.lab_list.TabIndex = 0;
            this.lab_list.Text = "Soccer Team List:";
            this.lab_list.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_add_team
            // 
            this.lab_add_team.AutoSize = true;
            this.lab_add_team.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_add_team.Location = new System.Drawing.Point(134, 11);
            this.lab_add_team.Name = "lab_add_team";
            this.lab_add_team.Size = new System.Drawing.Size(106, 20);
            this.lab_add_team.TabIndex = 1;
            this.lab_add_team.Text = "Adding Team:";
            // 
            // lab_add_teamm
            // 
            this.lab_add_teamm.AutoSize = true;
            this.lab_add_teamm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_add_teamm.Location = new System.Drawing.Point(716, 11);
            this.lab_add_teamm.Name = "lab_add_teamm";
            this.lab_add_teamm.Size = new System.Drawing.Size(112, 20);
            this.lab_add_teamm.TabIndex = 2;
            this.lab_add_teamm.Text = "Adding Player:";
            this.lab_add_teamm.Click += new System.EventHandler(this.label3_Click);
            // 
            // lab_coun
            // 
            this.lab_coun.AutoSize = true;
            this.lab_coun.Location = new System.Drawing.Point(494, 174);
            this.lab_coun.Name = "lab_coun";
            this.lab_coun.Size = new System.Drawing.Size(113, 20);
            this.lab_coun.TabIndex = 3;
            this.lab_coun.Text = "Choose Country";
            // 
            // lab_team
            // 
            this.lab_team.AutoSize = true;
            this.lab_team.Location = new System.Drawing.Point(509, 210);
            this.lab_team.Name = "lab_team";
            this.lab_team.Size = new System.Drawing.Size(98, 20);
            this.lab_team.TabIndex = 4;
            this.lab_team.Text = "Choose Team";
            // 
            // lab_nameTeam
            // 
            this.lab_nameTeam.AutoSize = true;
            this.lab_nameTeam.Location = new System.Drawing.Point(248, 11);
            this.lab_nameTeam.Name = "lab_nameTeam";
            this.lab_nameTeam.Size = new System.Drawing.Size(89, 20);
            this.lab_nameTeam.TabIndex = 5;
            this.lab_nameTeam.Text = "Team Name";
            // 
            // lab_country
            // 
            this.lab_country.AutoSize = true;
            this.lab_country.Location = new System.Drawing.Point(248, 46);
            this.lab_country.Name = "lab_country";
            this.lab_country.Size = new System.Drawing.Size(100, 20);
            this.lab_country.TabIndex = 6;
            this.lab_country.Text = "Team Country";
            // 
            // lab_city
            // 
            this.lab_city.AutoSize = true;
            this.lab_city.Location = new System.Drawing.Point(248, 81);
            this.lab_city.Name = "lab_city";
            this.lab_city.Size = new System.Drawing.Size(74, 20);
            this.lab_city.TabIndex = 7;
            this.lab_city.Text = "Team City";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(830, 11);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(93, 20);
            this.lab_name.TabIndex = 8;
            this.lab_name.Text = "Player Name";
            this.lab_name.Click += new System.EventHandler(this.label9_Click);
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(830, 46);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(107, 20);
            this.lab_num.TabIndex = 9;
            this.lab_num.Text = "Player Number";
            // 
            // lab_pos
            // 
            this.lab_pos.AutoSize = true;
            this.lab_pos.Location = new System.Drawing.Point(830, 81);
            this.lab_pos.Name = "lab_pos";
            this.lab_pos.Size = new System.Drawing.Size(105, 20);
            this.lab_pos.TabIndex = 10;
            this.lab_pos.Text = "Player Position";
            // 
            // but_addTeam
            // 
            this.but_addTeam.Location = new System.Drawing.Point(134, 41);
            this.but_addTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_addTeam.Name = "but_addTeam";
            this.but_addTeam.Size = new System.Drawing.Size(86, 31);
            this.but_addTeam.TabIndex = 11;
            this.but_addTeam.Text = "Add";
            this.but_addTeam.UseVisualStyleBackColor = true;
            this.but_addTeam.Click += new System.EventHandler(this.button_add_team_Click);
            // 
            // but_addPlayer
            // 
            this.but_addPlayer.Location = new System.Drawing.Point(716, 41);
            this.but_addPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_addPlayer.Name = "but_addPlayer";
            this.but_addPlayer.Size = new System.Drawing.Size(86, 31);
            this.but_addPlayer.TabIndex = 12;
            this.but_addPlayer.Text = "Add";
            this.but_addPlayer.UseVisualStyleBackColor = true;
            this.but_addPlayer.Click += new System.EventHandler(this.button_add_player_Click);
            // 
            // cbox_coun
            // 
            this.cbox_coun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_coun.FormattingEnabled = true;
            this.cbox_coun.Location = new System.Drawing.Point(613, 174);
            this.cbox_coun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_coun.Name = "cbox_coun";
            this.cbox_coun.Size = new System.Drawing.Size(138, 28);
            this.cbox_coun.TabIndex = 13;
            this.cbox_coun.SelectionChangeCommitted += new System.EventHandler(this.Country_Selected);
            // 
            // cbox_team
            // 
            this.cbox_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_team.FormattingEnabled = true;
            this.cbox_team.Location = new System.Drawing.Point(613, 210);
            this.cbox_team.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_team.Name = "cbox_team";
            this.cbox_team.Size = new System.Drawing.Size(138, 28);
            this.cbox_team.TabIndex = 14;
            this.cbox_team.SelectionChangeCommitted += new System.EventHandler(this.Team_Selected);
            // 
            // output_players
            // 
            this.output_players.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.output_players.FormattingEnabled = true;
            this.output_players.ItemHeight = 31;
            this.output_players.Location = new System.Drawing.Point(63, 257);
            this.output_players.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.output_players.Name = "output_players";
            this.output_players.Size = new System.Drawing.Size(1077, 252);
            this.output_players.TabIndex = 15;
            this.output_players.SelectedValueChanged += new System.EventHandler(this.lbox_value_change);
            // 
            // but_remove
            // 
            this.but_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.but_remove.Location = new System.Drawing.Point(427, 529);
            this.but_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_remove.Name = "but_remove";
            this.but_remove.Size = new System.Drawing.Size(375, 42);
            this.but_remove.TabIndex = 16;
            this.but_remove.Text = "Remove";
            this.but_remove.UseVisualStyleBackColor = true;
            this.but_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // tbox_tname
            // 
            this.tbox_tname.Location = new System.Drawing.Point(361, 11);
            this.tbox_tname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_tname.Name = "tbox_tname";
            this.tbox_tname.Size = new System.Drawing.Size(138, 27);
            this.tbox_tname.TabIndex = 17;
            // 
            // tbox_tcoun
            // 
            this.tbox_tcoun.Location = new System.Drawing.Point(361, 46);
            this.tbox_tcoun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_tcoun.Name = "tbox_tcoun";
            this.tbox_tcoun.Size = new System.Drawing.Size(138, 27);
            this.tbox_tcoun.TabIndex = 18;
            // 
            // tbox_tcity
            // 
            this.tbox_tcity.Location = new System.Drawing.Point(361, 81);
            this.tbox_tcity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_tcity.Name = "tbox_tcity";
            this.tbox_tcity.Size = new System.Drawing.Size(138, 27);
            this.tbox_tcity.TabIndex = 19;
            // 
            // tbox_pname
            // 
            this.tbox_pname.Location = new System.Drawing.Point(943, 11);
            this.tbox_pname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_pname.Name = "tbox_pname";
            this.tbox_pname.Size = new System.Drawing.Size(138, 27);
            this.tbox_pname.TabIndex = 20;
            // 
            // tbox_pnum
            // 
            this.tbox_pnum.Location = new System.Drawing.Point(943, 46);
            this.tbox_pnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_pnum.Name = "tbox_pnum";
            this.tbox_pnum.Size = new System.Drawing.Size(138, 27);
            this.tbox_pnum.TabIndex = 21;
            // 
            // cbox_ppos
            // 
            this.cbox_ppos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ppos.FormattingEnabled = true;
            this.cbox_ppos.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cbox_ppos.Location = new System.Drawing.Point(943, 81);
            this.cbox_ppos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_ppos.Name = "cbox_ppos";
            this.cbox_ppos.Size = new System.Drawing.Size(138, 28);
            this.cbox_ppos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 628);
            this.Controls.Add(this.cbox_ppos);
            this.Controls.Add(this.tbox_pnum);
            this.Controls.Add(this.tbox_pname);
            this.Controls.Add(this.tbox_tcity);
            this.Controls.Add(this.tbox_tcoun);
            this.Controls.Add(this.tbox_tname);
            this.Controls.Add(this.but_remove);
            this.Controls.Add(this.output_players);
            this.Controls.Add(this.cbox_team);
            this.Controls.Add(this.cbox_coun);
            this.Controls.Add(this.but_addPlayer);
            this.Controls.Add(this.but_addTeam);
            this.Controls.Add(this.lab_pos);
            this.Controls.Add(this.lab_num);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.lab_city);
            this.Controls.Add(this.lab_country);
            this.Controls.Add(this.lab_nameTeam);
            this.Controls.Add(this.lab_team);
            this.Controls.Add(this.lab_coun);
            this.Controls.Add(this.lab_add_teamm);
            this.Controls.Add(this.lab_add_team);
            this.Controls.Add(this.lab_list);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lab_list;
        private Label lab_add_team;
        private Label lab_add_teamm;
        private Label lab_coun;
        private Label lab_team;
        private Label lab_nameTeam;
        private Label lab_country;
        private Label lab_city;
        private Label lab_name;
        private Label lab_num;
        private Label lab_pos;
        private Button but_addTeam;
        private Button but_addPlayer;
        private ComboBox cbox_coun;
        private ComboBox cbox_team;
        private ListBox output_players;
        private Button but_remove;
        private TextBox tbox_tname;
        private TextBox tbox_tcoun;
        private TextBox tbox_tcity;
        private TextBox tbox_pname;
        private TextBox tbox_pnum;
        private ComboBox cbox_ppos;
    }
}