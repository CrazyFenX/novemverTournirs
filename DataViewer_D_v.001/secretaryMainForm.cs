﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataViewer_D_v._001
{
    public partial class secretaryMainForm : Form
    {
        startWindow startWindow = new startWindow();

        public secretaryMainForm()
        {
            InitializeComponent();
        }

        private void secretaryMainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            secretaryForm secretaryForm = new secretaryForm(this);

            this.Enabled = false;
            secretaryForm.Show();
            //Открытие коннекта
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            startWindow.Show();

            startWindow.registratorButton.Visible = true;
            startWindow.secretaryButton.Visible = true;
            startWindow.Exit_button.Visible = true;

            startWindow.backButton.Visible = false;
            startWindow.solistButton.Visible = false;
            startWindow.duetButton.Visible = false;
            startWindow.sekwayButton.Visible = false;
            startWindow.ansamblButton.Visible = false;
        }

        private void secretaryMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            startWindow.Show();

            startWindow.registratorButton.Visible = true;
            startWindow.secretaryButton.Visible = true;
            startWindow.Exit_button.Visible = true;

            startWindow.backButton.Visible = false;
            startWindow.solistButton.Visible = false;
            startWindow.duetButton.Visible = false;
            startWindow.sekwayButton.Visible = false;
            startWindow.ansamblButton.Visible = false;
        }
    }
}