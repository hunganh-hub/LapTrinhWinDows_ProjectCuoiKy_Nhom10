using Note.Models;
using Note.Views;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Note.Controllers;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Note
{
    public partial class frmMainSimpleNote : Form
    {
     //   private int ID;
      //  private List<ClassNote> listTasks;
        private bool isFileAlreadySave;
        private bool isFileDirty;
        private string currentOpenFileName;
        public frmMainSimpleNote()
        {    
            InitializeComponent();
            upDateListLoadNote();
            // loadnote();
        }
        
       
        #region Show Application + Members
        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawNote h = new DrawNote();
            h.ShowDialog();
            this.Show();
        }
        private void introduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroduceSimpleNote h = new IntroduceSimpleNote();
            h.ShowDialog();
            this.Show();
        }
        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trần Thị Lệ Xuân - 18133066 \nTrương Hùng Anh - 18133001 \nTrịnh Công Viễn - 18133061", "Members");
        }
        #endregion
        #region Open + New (Note + File)+ Save + SaveAs Click
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenKlyeMethod();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtContent.Clear();
            txtTitle.Clear();
            if (isFileDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes ? ", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        savefilemenu();
                        break;
                    case DialogResult.No:

                        break;
                    case DialogResult.Cancel:
                        MessageBox.Show("Develop by XuanTran  ", "Go to New File", MessageBoxButtons.OK);
                        //undoKlyeMethod();
                        break;
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefilemenu();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFileKaMethod();
            this.rtxtContent.Text = "";
            this.txtTitle.Text = "";
        }
        #endregion
        #region Exit Note Click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Save + SaveAs + Open
        private void savefilemenu()
        {

            if (isFileAlreadySave)
            {

                if (Path.GetExtension(currentOpenFileName) == ".txt")
                    rtxtContent.SaveFile(currentOpenFileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(currentOpenFileName) == ".php")
                    rtxtContent.SaveFile(currentOpenFileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(currentOpenFileName) == ".rtf")
                    rtxtContent.SaveFile(currentOpenFileName, RichTextBoxStreamType.RichText);

                isFileDirty = false;
                MessageBox.Show("Saved");
            }
            else
            {
                SaveAsFileKaMethod();
                this.rtxtContent.Text = "";

            }
        }
        private void SaveAsFileKaMethod()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|MSWord Files (*.docx)|*.docx|PHP (*.php)|*.php";
            DialogResult result = savefiledialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(savefiledialog.FileName) == ".txt")
                    rtxtContent.SaveFile(savefiledialog.FileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(savefiledialog.FileName) == ".php")
                    rtxtContent.SaveFile(savefiledialog.FileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(savefiledialog.FileName) == ".rtf")
                    rtxtContent.SaveFile(savefiledialog.FileName, RichTextBoxStreamType.RichText);

                isFileAlreadySave = true;
                isFileDirty = false;
                currentOpenFileName = savefiledialog.FileName;
            }
        }
        private void OpenKlyeMethod()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|MSWord Files (*.docx)|*.docx|PHP (*.php)|*.php";

            DialogResult result = openfiledialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openfiledialog.FileName) == ".txt")

                    rtxtContent.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(openfiledialog.FileName) == ".php")
                    rtxtContent.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.PlainText);



                if (Path.GetExtension(openfiledialog.FileName) == ".rtf")
                    rtxtContent.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.RichText);
                isFileAlreadySave = true;
                isFileDirty = false;
                currentOpenFileName = openfiledialog.FileName;

                // EnableDisableUndoRedoProcessKaMethog(false);

            }
        }
        #endregion

        private void EnableDisableUndoRedoProcessKaMethog(bool enable)
        {
            //undoToolStripMenuItem.Enabled = enable;
            //redoToolStripMenuItem.Enabled = enable;
        }
        #region add dữ liệu + xóa + load qua list
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            //ListViewItem eNote = new ListViewItem(this.ID.ToString());
            //eNote.SubItems.Add(new ListViewItem.ListViewSubItem(eNote, txtTitle.Text));
            //eNote.SubItems.Add(new ListViewItem.ListViewSubItem(eNote, rtxtContent.Text));
            //this.ListLoadNote.Items.Add(eNote);
            //this.ID += 1;
            //ResetData();
            //MessageBox.Show("Saved");

            ContentNote _note = new ContentNote();
            var id = NoteContentControllers.getIDfromDB();
            _note.ID = id;
            _note.Title = this.txtTitle.Text;
            _note.NoteContent = this.rtxtContent.Text;
            NoteContentControllers.AddNote(_note);
            this.txtTitle.ResetText();
            this.rtxtContent.ResetText();
            MessageBox.Show("Saved");
            DisplayNote();

        }
        private void DisplayNote()
        {
            List<ContentNote> lNote = NoteContentControllers.getAllNote();
            this.ListLoadNote.Items.Clear();
            foreach(ContentNote notes in lNote)
            {
                ListViewItem eNote = new ListViewItem(notes.ID.ToString());
                eNote.SubItems.Add(new ListViewItem.ListViewSubItem(eNote, notes.Title));
                eNote.SubItems.Add(new ListViewItem.ListViewSubItem(eNote, notes.NoteContent));
                this.ListLoadNote.Items.Add(eNote);
            }
        }
        //private void ResetData()
        //{
        //    this.txtTitle.Clear();
        //    this.rtxtContent.Clear();
        //}
        private void ListLoadNote_Click(object sender, EventArgs e)
        {
            this.txtTitle.Text = this.ListLoadNote.SelectedItems[0].SubItems[1].Text.Trim();
            this.rtxtContent.Text = this.ListLoadNote.SelectedItems[0].SubItems[2].Text.Trim();
        }

        private void DeleteNote_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("You certainly deleted?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            //    {
            //        ListLoadNote.Items.RemoveAt(ListLoadNote.SelectedIndices[0]);
            //        MessageBox.Show("Delete successful");
            //        NoteContentControllers.xoaNote(this.ListLoadNote.SelectedItems[0].Index);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Select the Note ID to delete?", "WARRING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //}
            //rtxtContent.Clear();
            //txtTitle.Clear();
            if(ListLoadNote.SelectedItems.Count==0)
            {
                MessageBox.Show("Select the Note ID to delete?", "WARRING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                NoteContentControllers.xoaNote(int.Parse(this.ListLoadNote.SelectedItems[0].SubItems[0].Text.Trim()));
                ListLoadNote.Items.RemoveAt(ListLoadNote.SelectedIndices[0]);
                MessageBox.Show("Delete successful");
                rtxtContent.Clear();
                txtTitle.Clear();
            }

        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            if(ListLoadNote.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select the Note ID to delete?", "WARRING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                NoteContentControllers.suaNote(int.Parse(this.ListLoadNote.SelectedItems[0].SubItems[0].Text.Trim()), this.txtTitle.Text.Trim(), this.rtxtContent.Text.Trim());
                upDateListLoadNote();
                MessageBox.Show("Saved");
            }
                
        }
        private void upDateListLoadNote()
        {
            this.ListLoadNote.Items.Clear();
            ContentNote _note = new ContentNote();
            
            foreach(var id in NoteContentControllers.getListIDfromDB())
            {
                _note.ID = id;
                _note.Title = this.txtTitle.Text;
                _note.NoteContent = this.rtxtContent.Text;

            }

            
            this.txtTitle.ResetText();
            this.rtxtContent.ResetText();
            //
            DisplayNote();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.lstSearchName.Items.Clear();
            //// tìm user
            //List<User> searchUser = this.listUsers.Where(x => x.UserName.Contains(this.txtSearchName.Text)).ToList();
            //if (searchUser.Count > 0)
            //{
            //    this.lstSearchName.Visible = true;
            //}
            //else
            //{
            //    this.lstSearchName.Visible = false;
            //}
            //for (int i = 0; i < searchUser.Count; i++)
            //{
            //    this.lstSearchName.Items.Add(searchUser[i]);
            //}
            List<ContentNote> listNote = NoteContentControllers.getAllNote().Where(x => x.Title.Contains(this.txtSearch.Text.Trim())).ToList();
            this.ListLoadNote.Items.Clear();
            for(int i=0;i<listNote.Count;i++)
            {
                ListViewItem eNote = new ListViewItem(listNote[i].ID.ToString().Trim());
                eNote.SubItems.Add(new ListViewItem.ListViewSubItem(eNote, listNote[i].Title.Trim()));
                eNote.SubItems.Add(new ListViewItem.ListViewSubItem(eNote, listNote[i].NoteContent.Trim()));
                this.ListLoadNote.Items.Add(eNote);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListLoadNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
