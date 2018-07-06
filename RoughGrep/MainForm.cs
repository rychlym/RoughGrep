﻿using System;
using System.Windows.Forms;
using TrivialBehind;

namespace RoughGrep
{

    public partial class MainForm : Form
    {
        IDisposable behindDisposer;
        public MainForm()
        {
            InitializeComponent();
            
            behindDisposer = TrivialBehinds.CreateForUi(new MainFormUi
            {
                form = this,
                dirSelector = dirSelector,
                resultBox = resultBox,
                previewBox = previewBox,
                searchTextBox = searchTextBox
            });
            this.Deactivate += (o, e) => behindDisposer.Dispose();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}