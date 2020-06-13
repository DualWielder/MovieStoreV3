﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public sealed partial class frmMain : Form
    {   //Singleton
        private static readonly frmMain _Instance = new frmMain();

        //private clsArtistList _ArtistList = new clsArtistList();

        public delegate void Notify(string prGalleryName);

        public event Notify GalleryNameChanged;

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Gallery (v3 C) - " + prGalleryName;
        }

        public async void UpdateDisplay()
        {
            try
            {
                lstGenres.DataSource = null;
                lstGenres.DataSource = await ServiceClient.GetGenreNamesAsync();

            }
            catch (Exception ex)
            { 
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //frmArtist.Run(new clsArtist(_ArtistList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new artist");
            }
        }

        private void lstGenres_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstGenres.SelectedItem);
            if (lcKey != null)
            try
            {
                frmGenre.Run(lstGenres.SelectedItem as string);
            }
             catch (Exception ex)
            {
             MessageBox.Show(ex.Message, "This should never occur");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string lcKey;

            //lcKey = Convert.ToString(lstArtists.SelectedItem);
           // if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //try
                //{
                   // _ArtistList.Remove(lcKey);
                   // lstArtists.ClearSelected();
                    //UpdateDisplay();

                //}
                //catch (Exception ex)
                //{
                    //MessageBox.Show(ex.Message, "Error deleting artist");
                //}
        }


        private void btnGalName_Click(object sender, EventArgs e)
        {
            //_ArtistList.GalleryName = new InputBox("Enter Gallery Name:").Answer;
           // GalleryNameChanged(_ArtistList.GalleryName);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
