namespace CryptotextEditor
{
    partial class Editor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileLastOpened = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditMarkupAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditText = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditTextUppercase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditTextLowercase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditTextSentenceCase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatDetectUrls = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatAlig = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatAligLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatAligCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatAligRight = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFormatToolbox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFormatReset = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionAES = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionBase64 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionBase64encode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionBase64decode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionArcs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionByteEncode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionByteDecode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionLeetspeak = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEncryptionRot13 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHash = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHashFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHashMd5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHashSha1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHashSha256 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHashSha384 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHashSha512 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHashRipemd160 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLangEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLangGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLangSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSystemTray = new System.Windows.Forms.ToolStripMenuItem();
            this.Document = new System.Windows.Forms.RichTextBox();
            this.documentMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.docMenuStripDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.docMenuStripFont = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripFontSize8 = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripFontSize12 = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripFontSize14 = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripFontSize16 = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripTextCase = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripTextCaseUp = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripTextCaseLower = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripTextCaseSentence = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.docMenuStripCut = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.docMenuStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheckFunctions = new System.Windows.Forms.Timer(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusLabelLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelFont = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelSearchFor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearchingString = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSearchBigSmallYes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonCloseSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripAES = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelAesEnc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxAESPassphrase = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonAESencrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAESdecrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCloseAES = new System.Windows.Forms.ToolStripButton();
            this.notifyIconCryptotextEditor = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.mtsNew = new System.Windows.Forms.ToolStripButton();
            this.mtsOpen = new System.Windows.Forms.ToolStripButton();
            this.mtsSave = new System.Windows.Forms.ToolStripButton();
            this.mtsProperties = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsUndo = new System.Windows.Forms.ToolStripButton();
            this.mtsRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsCut = new System.Windows.Forms.ToolStripButton();
            this.mtsCopy = new System.Windows.Forms.ToolStripButton();
            this.mtsPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsSearch = new System.Windows.Forms.ToolStripButton();
            this.mtsFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsAES = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsBase64encode = new System.Windows.Forms.ToolStripButton();
            this.mtsBase64decode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsLeetspeak = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.documentMenuStrip.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.toolStripSearch.SuspendLayout();
            this.toolStripAES.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemFormat,
            this.MenuItemEncryption,
            this.MenuItemHash,
            this.MenuItemLang,
            this.MenuItemAbout,
            this.MenuItemSystemTray});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.toolStripSeparator9,
            this.MenuItemFileProperties,
            this.toolStripSeparator1,
            this.MenuItemFileLastOpened,
            this.toolStripSeparator3,
            this.MenuItemFileClose});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Image = global::CryptotextEditor.Properties.Resources.g6247;
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemFileNew.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileNew.Text = "Новый";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Image = global::CryptotextEditor.Properties.Resources.g5442;
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemFileOpen.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileOpen.Text = "Открыть";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Image = global::CryptotextEditor.Properties.Resources.g5969;
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemFileSave.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileSave.Text = "Сохранить";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.MenuItemFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileSaveAs.Text = "Сохранить как";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(223, 6);
            // 
            // MenuItemFileProperties
            // 
            this.MenuItemFileProperties.Enabled = false;
            this.MenuItemFileProperties.Image = global::CryptotextEditor.Properties.Resources.properties;
            this.MenuItemFileProperties.Name = "MenuItemFileProperties";
            this.MenuItemFileProperties.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileProperties.Text = "CTXT настройки";
            this.MenuItemFileProperties.Click += new System.EventHandler(this.MenuItemFileProperties_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // MenuItemFileLastOpened
            // 
            this.MenuItemFileLastOpened.Name = "MenuItemFileLastOpened";
            this.MenuItemFileLastOpened.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileLastOpened.Text = "Последний открытый файл";
            this.MenuItemFileLastOpened.Click += new System.EventHandler(this.MenuItemFileLastOpened_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // MenuItemFileClose
            // 
            this.MenuItemFileClose.Image = global::CryptotextEditor.Properties.Resources.cross;
            this.MenuItemFileClose.Name = "MenuItemFileClose";
            this.MenuItemFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MenuItemFileClose.Size = new System.Drawing.Size(226, 22);
            this.MenuItemFileClose.Text = "Закрыть";
            this.MenuItemFileClose.Click += new System.EventHandler(this.MenuItemFileClose_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditUndo,
            this.MenuItemEditRedo,
            this.MenuItemEditSeparator,
            this.MenuItemEditCut,
            this.MenuItemEditCopy,
            this.MenuItemEditPaste,
            this.MenuItemEditDelete,
            this.MenuItemEditMarkupAll,
            this.toolStripSeparator2,
            this.MenuItemEditSearch,
            this.toolStripSeparator4,
            this.MenuItemEditText,
            this.MenuItemEditTimeDate});
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(73, 20);
            this.MenuItemEdit.Text = "Изменить";
            // 
            // MenuItemEditUndo
            // 
            this.MenuItemEditUndo.Enabled = false;
            this.MenuItemEditUndo.Image = global::CryptotextEditor.Properties.Resources.g5935;
            this.MenuItemEditUndo.Name = "MenuItemEditUndo";
            this.MenuItemEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuItemEditUndo.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditUndo.Text = "Назад";
            this.MenuItemEditUndo.Click += new System.EventHandler(this.MenuItemEditUndo_Click);
            // 
            // MenuItemEditRedo
            // 
            this.MenuItemEditRedo.Enabled = false;
            this.MenuItemEditRedo.Image = global::CryptotextEditor.Properties.Resources.g5925;
            this.MenuItemEditRedo.Name = "MenuItemEditRedo";
            this.MenuItemEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuItemEditRedo.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditRedo.Text = "Вперед";
            this.MenuItemEditRedo.Click += new System.EventHandler(this.MenuItemEditRedo_Click);
            // 
            // MenuItemEditSeparator
            // 
            this.MenuItemEditSeparator.Name = "MenuItemEditSeparator";
            this.MenuItemEditSeparator.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItemEditCut
            // 
            this.MenuItemEditCut.Enabled = false;
            this.MenuItemEditCut.Image = global::CryptotextEditor.Properties.Resources.g5889;
            this.MenuItemEditCut.Name = "MenuItemEditCut";
            this.MenuItemEditCut.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditCut.Text = "Вырезать";
            this.MenuItemEditCut.Click += new System.EventHandler(this.MenuItemEditCut_Click);
            // 
            // MenuItemEditCopy
            // 
            this.MenuItemEditCopy.Enabled = false;
            this.MenuItemEditCopy.Image = global::CryptotextEditor.Properties.Resources.g5782;
            this.MenuItemEditCopy.Name = "MenuItemEditCopy";
            this.MenuItemEditCopy.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditCopy.Text = "Копировать";
            this.MenuItemEditCopy.Click += new System.EventHandler(this.MenuItemEditCopy_Click);
            // 
            // MenuItemEditPaste
            // 
            this.MenuItemEditPaste.Image = global::CryptotextEditor.Properties.Resources.g6024;
            this.MenuItemEditPaste.Name = "MenuItemEditPaste";
            this.MenuItemEditPaste.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditPaste.Text = "Вставить";
            this.MenuItemEditPaste.Click += new System.EventHandler(this.MenuItemEditPaste_Click);
            // 
            // MenuItemEditDelete
            // 
            this.MenuItemEditDelete.Enabled = false;
            this.MenuItemEditDelete.Name = "MenuItemEditDelete";
            this.MenuItemEditDelete.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditDelete.Text = "Удалить";
            this.MenuItemEditDelete.Click += new System.EventHandler(this.MenuItemEditDelete_Click);
            // 
            // MenuItemEditMarkupAll
            // 
            this.MenuItemEditMarkupAll.Name = "MenuItemEditMarkupAll";
            this.MenuItemEditMarkupAll.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditMarkupAll.Text = "Пометить все";
            this.MenuItemEditMarkupAll.Click += new System.EventHandler(this.MenuItemEditMarkupAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItemEditSearch
            // 
            this.MenuItemEditSearch.Image = global::CryptotextEditor.Properties.Resources.g6038;
            this.MenuItemEditSearch.Name = "MenuItemEditSearch";
            this.MenuItemEditSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MenuItemEditSearch.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditSearch.Text = "Поиск";
            this.MenuItemEditSearch.Click += new System.EventHandler(this.MenuItemEditSearch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // MenuItemEditText
            // 
            this.MenuItemEditText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditTextUppercase,
            this.MenuItemEditTextLowercase,
            this.MenuItemEditTextSentenceCase});
            this.MenuItemEditText.Name = "MenuItemEditText";
            this.MenuItemEditText.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditText.Text = "Преобразовать текст";
            // 
            // MenuItemEditTextUppercase
            // 
            this.MenuItemEditTextUppercase.Name = "MenuItemEditTextUppercase";
            this.MenuItemEditTextUppercase.Size = new System.Drawing.Size(197, 22);
            this.MenuItemEditTextUppercase.Text = "ВЕРХНИЙ РЕГИСТР";
            this.MenuItemEditTextUppercase.Click += new System.EventHandler(this.MenuItemEditTextUppercase_Click);
            // 
            // MenuItemEditTextLowercase
            // 
            this.MenuItemEditTextLowercase.Name = "MenuItemEditTextLowercase";
            this.MenuItemEditTextLowercase.Size = new System.Drawing.Size(197, 22);
            this.MenuItemEditTextLowercase.Text = "нижний регистр";
            this.MenuItemEditTextLowercase.Click += new System.EventHandler(this.MenuItemEditTextLowercase_Click);
            // 
            // MenuItemEditTextSentenceCase
            // 
            this.MenuItemEditTextSentenceCase.Name = "MenuItemEditTextSentenceCase";
            this.MenuItemEditTextSentenceCase.Size = new System.Drawing.Size(197, 22);
            this.MenuItemEditTextSentenceCase.Text = "Регистр Предложения";
            this.MenuItemEditTextSentenceCase.Click += new System.EventHandler(this.MenuItemEditTextSentenceCase_Click);
            // 
            // MenuItemEditTimeDate
            // 
            this.MenuItemEditTimeDate.Name = "MenuItemEditTimeDate";
            this.MenuItemEditTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuItemEditTimeDate.Size = new System.Drawing.Size(189, 22);
            this.MenuItemEditTimeDate.Text = "Время/Дата";
            this.MenuItemEditTimeDate.Click += new System.EventHandler(this.MenuItemEditTimeDate_Click);
            // 
            // MenuItemFormat
            // 
            this.MenuItemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFormatWordWrap,
            this.MenuItemFormatDetectUrls,
            this.MenuItemFormatAutoSave,
            this.MenuItemFormatFont,
            this.MenuItemFormatAlig,
            this.MenuItemFormatToolbox,
            this.toolStripSeparator8,
            this.MenuItemFormatReset});
            this.MenuItemFormat.Name = "MenuItemFormat";
            this.MenuItemFormat.Size = new System.Drawing.Size(62, 20);
            this.MenuItemFormat.Text = "Формат";
            // 
            // MenuItemFormatWordWrap
            // 
            this.MenuItemFormatWordWrap.Checked = true;
            this.MenuItemFormatWordWrap.CheckOnClick = true;
            this.MenuItemFormatWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemFormatWordWrap.Name = "MenuItemFormatWordWrap";
            this.MenuItemFormatWordWrap.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatWordWrap.Text = "Перенос слов";
            this.MenuItemFormatWordWrap.CheckedChanged += new System.EventHandler(this.MenuItemFormatWordWrap_CheckedChanged);
            // 
            // MenuItemFormatDetectUrls
            // 
            this.MenuItemFormatDetectUrls.Checked = true;
            this.MenuItemFormatDetectUrls.CheckOnClick = true;
            this.MenuItemFormatDetectUrls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemFormatDetectUrls.Name = "MenuItemFormatDetectUrls";
            this.MenuItemFormatDetectUrls.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatDetectUrls.Text = "Обнаружение URL-адресов";
            this.MenuItemFormatDetectUrls.CheckedChanged += new System.EventHandler(this.MenuItemFormatDetectUrls_CheckedChanged);
            // 
            // MenuItemFormatAutoSave
            // 
            this.MenuItemFormatAutoSave.Checked = true;
            this.MenuItemFormatAutoSave.CheckOnClick = true;
            this.MenuItemFormatAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemFormatAutoSave.Name = "MenuItemFormatAutoSave";
            this.MenuItemFormatAutoSave.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatAutoSave.Text = "АвтоСохранение";
            this.MenuItemFormatAutoSave.CheckedChanged += new System.EventHandler(this.MenuItemFormatAutoSave_CheckedChanged);
            // 
            // MenuItemFormatFont
            // 
            this.MenuItemFormatFont.Image = global::CryptotextEditor.Properties.Resources.font;
            this.MenuItemFormatFont.Name = "MenuItemFormatFont";
            this.MenuItemFormatFont.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatFont.Text = "Шрифт";
            this.MenuItemFormatFont.Click += new System.EventHandler(this.MenuItemFormatFont_Click);
            // 
            // MenuItemFormatAlig
            // 
            this.MenuItemFormatAlig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFormatAligLeft,
            this.MenuItemFormatAligCenter,
            this.MenuItemFormatAligRight});
            this.MenuItemFormatAlig.Name = "MenuItemFormatAlig";
            this.MenuItemFormatAlig.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatAlig.Text = "Выравнивание";
            // 
            // MenuItemFormatAligLeft
            // 
            this.MenuItemFormatAligLeft.Name = "MenuItemFormatAligLeft";
            this.MenuItemFormatAligLeft.Size = new System.Drawing.Size(131, 22);
            this.MenuItemFormatAligLeft.Text = "Слева";
            this.MenuItemFormatAligLeft.Click += new System.EventHandler(this.MenuItemFormatAligLeft_Click);
            // 
            // MenuItemFormatAligCenter
            // 
            this.MenuItemFormatAligCenter.Name = "MenuItemFormatAligCenter";
            this.MenuItemFormatAligCenter.Size = new System.Drawing.Size(131, 22);
            this.MenuItemFormatAligCenter.Text = "По центру";
            this.MenuItemFormatAligCenter.Click += new System.EventHandler(this.MenuItemFormatAligCenter_Click);
            // 
            // MenuItemFormatAligRight
            // 
            this.MenuItemFormatAligRight.Name = "MenuItemFormatAligRight";
            this.MenuItemFormatAligRight.Size = new System.Drawing.Size(131, 22);
            this.MenuItemFormatAligRight.Text = "Справа";
            this.MenuItemFormatAligRight.Click += new System.EventHandler(this.MenuItemFormatAligRight_Click);
            // 
            // MenuItemFormatToolbox
            // 
            this.MenuItemFormatToolbox.Checked = true;
            this.MenuItemFormatToolbox.CheckOnClick = true;
            this.MenuItemFormatToolbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemFormatToolbox.Name = "MenuItemFormatToolbox";
            this.MenuItemFormatToolbox.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatToolbox.Text = "Инструменты";
            this.MenuItemFormatToolbox.Click += new System.EventHandler(this.MenuItemFormatToolbox_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(263, 6);
            // 
            // MenuItemFormatReset
            // 
            this.MenuItemFormatReset.Name = "MenuItemFormatReset";
            this.MenuItemFormatReset.Size = new System.Drawing.Size(266, 22);
            this.MenuItemFormatReset.Text = "Сброс до значений по умолчанию";
            this.MenuItemFormatReset.Click += new System.EventHandler(this.MenuItemFormatReset_Click);
            // 
            // MenuItemEncryption
            // 
            this.MenuItemEncryption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEncryptionAES,
            this.MenuItemEncryptionBase64,
            this.MenuItemEncryptionArcs,
            this.MenuItemEncryptionLeetspeak,
            this.MenuItemEncryptionRot13});
            this.MenuItemEncryption.Name = "MenuItemEncryption";
            this.MenuItemEncryption.Size = new System.Drawing.Size(92, 20);
            this.MenuItemEncryption.Tag = "";
            this.MenuItemEncryption.Text = "Шифрование";
            // 
            // MenuItemEncryptionAES
            // 
            this.MenuItemEncryptionAES.Image = global::CryptotextEditor.Properties.Resources.aes;
            this.MenuItemEncryptionAES.Name = "MenuItemEncryptionAES";
            this.MenuItemEncryptionAES.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.MenuItemEncryptionAES.Size = new System.Drawing.Size(134, 22);
            this.MenuItemEncryptionAES.Text = "AES";
            this.MenuItemEncryptionAES.Click += new System.EventHandler(this.MenuItemEncryptionAES_Click);
            // 
            // MenuItemEncryptionBase64
            // 
            this.MenuItemEncryptionBase64.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEncryptionBase64encode,
            this.MenuItemEncryptionBase64decode});
            this.MenuItemEncryptionBase64.Name = "MenuItemEncryptionBase64";
            this.MenuItemEncryptionBase64.Size = new System.Drawing.Size(134, 22);
            this.MenuItemEncryptionBase64.Text = "Base64";
            // 
            // MenuItemEncryptionBase64encode
            // 
            this.MenuItemEncryptionBase64encode.Image = global::CryptotextEditor.Properties.Resources.g5426;
            this.MenuItemEncryptionBase64encode.Name = "MenuItemEncryptionBase64encode";
            this.MenuItemEncryptionBase64encode.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEncryptionBase64encode.Text = "Шифровать";
            this.MenuItemEncryptionBase64encode.Click += new System.EventHandler(this.MenuItemEncryptionBase64encode_Click);
            // 
            // MenuItemEncryptionBase64decode
            // 
            this.MenuItemEncryptionBase64decode.Image = global::CryptotextEditor.Properties.Resources.g5430;
            this.MenuItemEncryptionBase64decode.Name = "MenuItemEncryptionBase64decode";
            this.MenuItemEncryptionBase64decode.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEncryptionBase64decode.Text = "Дешифровать";
            this.MenuItemEncryptionBase64decode.Click += new System.EventHandler(this.MenuItemEncryptionBase64decode_Click);
            // 
            // MenuItemEncryptionArcs
            // 
            this.MenuItemEncryptionArcs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEncryptionByteEncode,
            this.MenuItemEncryptionByteDecode});
            this.MenuItemEncryptionArcs.Name = "MenuItemEncryptionArcs";
            this.MenuItemEncryptionArcs.Size = new System.Drawing.Size(134, 22);
            this.MenuItemEncryptionArcs.Text = "Bytes";
            // 
            // MenuItemEncryptionByteEncode
            // 
            this.MenuItemEncryptionByteEncode.Image = global::CryptotextEditor.Properties.Resources.g5426;
            this.MenuItemEncryptionByteEncode.Name = "MenuItemEncryptionByteEncode";
            this.MenuItemEncryptionByteEncode.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEncryptionByteEncode.Text = "Шифровать";
            this.MenuItemEncryptionByteEncode.Click += new System.EventHandler(this.MenuItemEncryptionBytesEncode_Click);
            // 
            // MenuItemEncryptionByteDecode
            // 
            this.MenuItemEncryptionByteDecode.Image = global::CryptotextEditor.Properties.Resources.g5430;
            this.MenuItemEncryptionByteDecode.Name = "MenuItemEncryptionByteDecode";
            this.MenuItemEncryptionByteDecode.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEncryptionByteDecode.Text = "Дешифровать";
            this.MenuItemEncryptionByteDecode.Click += new System.EventHandler(this.MenuItemEncryptionByteDecode_Click);
            // 
            // MenuItemEncryptionLeetspeak
            // 
            this.MenuItemEncryptionLeetspeak.Image = global::CryptotextEditor.Properties.Resources._1337;
            this.MenuItemEncryptionLeetspeak.Name = "MenuItemEncryptionLeetspeak";
            this.MenuItemEncryptionLeetspeak.Size = new System.Drawing.Size(134, 22);
            this.MenuItemEncryptionLeetspeak.Text = "1337";
            this.MenuItemEncryptionLeetspeak.Click += new System.EventHandler(this.MenuItemEncryptionLeetspeak_Click);
            // 
            // MenuItemEncryptionRot13
            // 
            this.MenuItemEncryptionRot13.Name = "MenuItemEncryptionRot13";
            this.MenuItemEncryptionRot13.Size = new System.Drawing.Size(134, 22);
            this.MenuItemEncryptionRot13.Text = "Rot13";
            this.MenuItemEncryptionRot13.Click += new System.EventHandler(this.MenuItemEncryptionRot13_Click);
            // 
            // MenuItemHash
            // 
            this.MenuItemHash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHashFile,
            this.toolStripSeparator16,
            this.MenuItemHashMd5,
            this.MenuItemHashSha1,
            this.MenuItemHashSha256,
            this.MenuItemHashSha384,
            this.MenuItemHashSha512,
            this.MenuItemHashRipemd160});
            this.MenuItemHash.Name = "MenuItemHash";
            this.MenuItemHash.Size = new System.Drawing.Size(43, 20);
            this.MenuItemHash.Text = "Хеш";
            // 
            // MenuItemHashFile
            // 
            this.MenuItemHashFile.Name = "MenuItemHashFile";
            this.MenuItemHashFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MenuItemHashFile.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashFile.Text = "Хеш файла";
            this.MenuItemHashFile.Click += new System.EventHandler(this.MenuItemFileHash_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(176, 6);
            // 
            // MenuItemHashMd5
            // 
            this.MenuItemHashMd5.Name = "MenuItemHashMd5";
            this.MenuItemHashMd5.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashMd5.Text = "md5";
            this.MenuItemHashMd5.Click += new System.EventHandler(this.MenuItemHashMd5_Click);
            // 
            // MenuItemHashSha1
            // 
            this.MenuItemHashSha1.Name = "MenuItemHashSha1";
            this.MenuItemHashSha1.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashSha1.Text = "SHA-1";
            this.MenuItemHashSha1.Click += new System.EventHandler(this.MenuItemHashSha1_Click);
            // 
            // MenuItemHashSha256
            // 
            this.MenuItemHashSha256.Name = "MenuItemHashSha256";
            this.MenuItemHashSha256.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashSha256.Text = "SHA-256";
            this.MenuItemHashSha256.Click += new System.EventHandler(this.MenuItemHashSha256_Click);
            // 
            // MenuItemHashSha384
            // 
            this.MenuItemHashSha384.Name = "MenuItemHashSha384";
            this.MenuItemHashSha384.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashSha384.Text = "SHA-384";
            this.MenuItemHashSha384.Click += new System.EventHandler(this.MenuItemHashSha384_Click);
            // 
            // MenuItemHashSha512
            // 
            this.MenuItemHashSha512.Name = "MenuItemHashSha512";
            this.MenuItemHashSha512.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashSha512.Text = "SHA-512";
            this.MenuItemHashSha512.Click += new System.EventHandler(this.MenuItemHashSha512_Click);
            // 
            // MenuItemHashRipemd160
            // 
            this.MenuItemHashRipemd160.Name = "MenuItemHashRipemd160";
            this.MenuItemHashRipemd160.Size = new System.Drawing.Size(179, 22);
            this.MenuItemHashRipemd160.Text = "RIPEMD 160";
            this.MenuItemHashRipemd160.Click += new System.EventHandler(this.MenuItemHashRipemd160_Click);
            // 
            // MenuItemLang
            // 
            this.MenuItemLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLangEnglish,
            this.MenuItemLangGerman,
            this.MenuItemLangSpanish});
            this.MenuItemLang.Name = "MenuItemLang";
            this.MenuItemLang.Size = new System.Drawing.Size(46, 20);
            this.MenuItemLang.Text = "Язык";
            // 
            // MenuItemLangEnglish
            // 
            this.MenuItemLangEnglish.Name = "MenuItemLangEnglish";
            this.MenuItemLangEnglish.Size = new System.Drawing.Size(152, 22);
            this.MenuItemLangEnglish.Text = "Русский";
            this.MenuItemLangEnglish.Click += new System.EventHandler(this.MenuItemLangEnglish_Click);
            // 
            // MenuItemLangGerman
            // 
            this.MenuItemLangGerman.Name = "MenuItemLangGerman";
            this.MenuItemLangGerman.Size = new System.Drawing.Size(152, 22);
            this.MenuItemLangGerman.Text = "Немецкий";
            this.MenuItemLangGerman.Click += new System.EventHandler(this.MenuItemLangGerman_Click);
            // 
            // MenuItemLangSpanish
            // 
            this.MenuItemLangSpanish.Name = "MenuItemLangSpanish";
            this.MenuItemLangSpanish.Size = new System.Drawing.Size(152, 22);
            this.MenuItemLangSpanish.Text = "Испанский";
            this.MenuItemLangSpanish.Click += new System.EventHandler(this.MenuItemLangSpanish_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(24, 20);
            this.MenuItemAbout.Text = "?";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MenuItemSystemTray
            // 
            this.MenuItemSystemTray.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemSystemTray.AutoToolTip = true;
            this.MenuItemSystemTray.Name = "MenuItemSystemTray";
            this.MenuItemSystemTray.Size = new System.Drawing.Size(31, 20);
            this.MenuItemSystemTray.Text = " v ";
            this.MenuItemSystemTray.ToolTipText = "System Tray";
            this.MenuItemSystemTray.Click += new System.EventHandler(this.MenuItemSystemTray_Click);
            // 
            // Document
            // 
            this.Document.AcceptsTab = true;
            this.Document.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.Document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Document.ContextMenuStrip = this.documentMenuStrip;
            this.Document.EnableAutoDragDrop = true;
            this.Document.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document.HideSelection = false;
            this.Document.Location = new System.Drawing.Point(0, 49);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(492, 296);
            this.Document.TabIndex = 1;
            this.Document.Text = "";
            this.Document.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.Document_LinkClicked);
            this.Document.SelectionChanged += new System.EventHandler(this.Document_SelectionChanged);
            this.Document.TextChanged += new System.EventHandler(this.Document_TextChanged);
            // 
            // documentMenuStrip
            // 
            this.documentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docMenuStripDefault,
            this.toolStripSeparator5,
            this.docMenuStripFont,
            this.docMenuStripFontSize,
            this.docMenuStripTextCase,
            this.toolStripSeparator6,
            this.docMenuStripCut,
            this.docMenuStripCopy,
            this.docMenuStripPaste});
            this.documentMenuStrip.Name = "documentMenuStrip";
            this.documentMenuStrip.Size = new System.Drawing.Size(152, 170);
            // 
            // docMenuStripDefault
            // 
            this.docMenuStripDefault.Name = "docMenuStripDefault";
            this.docMenuStripDefault.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripDefault.Text = "Default format";
            this.docMenuStripDefault.Click += new System.EventHandler(this.MenuItemFormatReset_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // docMenuStripFont
            // 
            this.docMenuStripFont.Image = global::CryptotextEditor.Properties.Resources.font;
            this.docMenuStripFont.Name = "docMenuStripFont";
            this.docMenuStripFont.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripFont.Text = "Font";
            this.docMenuStripFont.Click += new System.EventHandler(this.MenuItemFormatFont_Click);
            // 
            // docMenuStripFontSize
            // 
            this.docMenuStripFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docMenuStripFontSize8,
            this.docMenuStripFontSize12,
            this.docMenuStripFontSize14,
            this.docMenuStripFontSize16});
            this.docMenuStripFontSize.Name = "docMenuStripFontSize";
            this.docMenuStripFontSize.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripFontSize.Text = "Font size";
            // 
            // docMenuStripFontSize8
            // 
            this.docMenuStripFontSize8.Name = "docMenuStripFontSize8";
            this.docMenuStripFontSize8.Size = new System.Drawing.Size(86, 22);
            this.docMenuStripFontSize8.Text = "8";
            this.docMenuStripFontSize8.Click += new System.EventHandler(this.docMenuStripFontSize8_Click);
            // 
            // docMenuStripFontSize12
            // 
            this.docMenuStripFontSize12.Name = "docMenuStripFontSize12";
            this.docMenuStripFontSize12.Size = new System.Drawing.Size(86, 22);
            this.docMenuStripFontSize12.Text = "12";
            this.docMenuStripFontSize12.Click += new System.EventHandler(this.docMenuStripFontSize12_Click);
            // 
            // docMenuStripFontSize14
            // 
            this.docMenuStripFontSize14.Name = "docMenuStripFontSize14";
            this.docMenuStripFontSize14.Size = new System.Drawing.Size(86, 22);
            this.docMenuStripFontSize14.Text = "14";
            this.docMenuStripFontSize14.Click += new System.EventHandler(this.docMenuStripFontSize14_Click);
            // 
            // docMenuStripFontSize16
            // 
            this.docMenuStripFontSize16.Name = "docMenuStripFontSize16";
            this.docMenuStripFontSize16.Size = new System.Drawing.Size(86, 22);
            this.docMenuStripFontSize16.Text = "16";
            this.docMenuStripFontSize16.Click += new System.EventHandler(this.docMenuStripFontSize16_Click);
            // 
            // docMenuStripTextCase
            // 
            this.docMenuStripTextCase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docMenuStripTextCaseUp,
            this.docMenuStripTextCaseLower,
            this.docMenuStripTextCaseSentence});
            this.docMenuStripTextCase.Name = "docMenuStripTextCase";
            this.docMenuStripTextCase.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripTextCase.Text = "Convert text";
            // 
            // docMenuStripTextCaseUp
            // 
            this.docMenuStripTextCaseUp.Name = "docMenuStripTextCaseUp";
            this.docMenuStripTextCaseUp.Size = new System.Drawing.Size(150, 22);
            this.docMenuStripTextCaseUp.Text = "UPPERCASE";
            this.docMenuStripTextCaseUp.Click += new System.EventHandler(this.MenuItemEditTextUppercase_Click);
            // 
            // docMenuStripTextCaseLower
            // 
            this.docMenuStripTextCaseLower.Name = "docMenuStripTextCaseLower";
            this.docMenuStripTextCaseLower.Size = new System.Drawing.Size(150, 22);
            this.docMenuStripTextCaseLower.Text = "lowercase";
            this.docMenuStripTextCaseLower.Click += new System.EventHandler(this.MenuItemEditTextLowercase_Click);
            // 
            // docMenuStripTextCaseSentence
            // 
            this.docMenuStripTextCaseSentence.Name = "docMenuStripTextCaseSentence";
            this.docMenuStripTextCaseSentence.Size = new System.Drawing.Size(150, 22);
            this.docMenuStripTextCaseSentence.Text = "Sentence Case";
            this.docMenuStripTextCaseSentence.Click += new System.EventHandler(this.MenuItemEditTextSentenceCase_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(148, 6);
            // 
            // docMenuStripCut
            // 
            this.docMenuStripCut.Image = global::CryptotextEditor.Properties.Resources.cut;
            this.docMenuStripCut.Name = "docMenuStripCut";
            this.docMenuStripCut.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripCut.Text = "Cut";
            this.docMenuStripCut.Click += new System.EventHandler(this.MenuItemEditCut_Click);
            // 
            // docMenuStripCopy
            // 
            this.docMenuStripCopy.Image = global::CryptotextEditor.Properties.Resources.copy;
            this.docMenuStripCopy.Name = "docMenuStripCopy";
            this.docMenuStripCopy.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripCopy.Text = "Copy";
            this.docMenuStripCopy.Click += new System.EventHandler(this.MenuItemEditCopy_Click);
            // 
            // docMenuStripPaste
            // 
            this.docMenuStripPaste.Image = global::CryptotextEditor.Properties.Resources.paste;
            this.docMenuStripPaste.Name = "docMenuStripPaste";
            this.docMenuStripPaste.Size = new System.Drawing.Size(151, 22);
            this.docMenuStripPaste.Text = "Paste";
            this.docMenuStripPaste.Click += new System.EventHandler(this.MenuItemEditPaste_Click);
            // 
            // timerCheckFunctions
            // 
            this.timerCheckFunctions.Enabled = true;
            this.timerCheckFunctions.Interval = 500;
            this.timerCheckFunctions.Tick += new System.EventHandler(this.timerCheckFunctions_Tick);
            // 
            // statusStripMain
            // 
            this.statusStripMain.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelLines,
            this.statusLabelSelected,
            this.statusLabelFont});
            this.statusStripMain.Location = new System.Drawing.Point(0, 345);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(492, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // statusLabelLines
            // 
            this.statusLabelLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabelLines.Name = "statusLabelLines";
            this.statusLabelLines.Size = new System.Drawing.Size(108, 17);
            this.statusLabelLines.Text = "длина: 0   линии: 1";
            // 
            // statusLabelSelected
            // 
            this.statusLabelSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabelSelected.Name = "statusLabelSelected";
            this.statusLabelSelected.Size = new System.Drawing.Size(42, 17);
            this.statusLabelSelected.Text = "|  sel: 0";
            this.statusLabelSelected.Visible = false;
            // 
            // statusLabelFont
            // 
            this.statusLabelFont.Name = "statusLabelFont";
            this.statusLabelFont.Size = new System.Drawing.Size(369, 17);
            this.statusLabelFont.Spring = true;
            this.statusLabelFont.Text = "Arial, 12, Regular";
            this.statusLabelFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.toolStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelSearchFor,
            this.toolStripTextBoxSearchingString,
            this.toolStripButtonSearch,
            this.toolStripButtonCloseSearch});
            this.toolStripSearch.Location = new System.Drawing.Point(0, 49);
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(492, 25);
            this.toolStripSearch.TabIndex = 3;
            this.toolStripSearch.Text = "toolStripSearch";
            this.toolStripSearch.Visible = false;
            // 
            // toolStripLabelSearchFor
            // 
            this.toolStripLabelSearchFor.Name = "toolStripLabelSearchFor";
            this.toolStripLabelSearchFor.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabelSearchFor.Text = "Search for: ";
            // 
            // toolStripTextBoxSearchingString
            // 
            this.toolStripTextBoxSearchingString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBoxSearchingString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBoxSearchingString.Name = "toolStripTextBoxSearchingString";
            this.toolStripTextBoxSearchingString.Size = new System.Drawing.Size(150, 25);
            this.toolStripTextBoxSearchingString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxSearchingString_KeyDown);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchBigSmallYes});
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonSearch.Text = "Search";
            this.toolStripButtonSearch.ButtonClick += new System.EventHandler(this.toolStripButtonSearch_ButtonClick);
            // 
            // toolStripSearchBigSmallYes
            // 
            this.toolStripSearchBigSmallYes.Checked = true;
            this.toolStripSearchBigSmallYes.CheckOnClick = true;
            this.toolStripSearchBigSmallYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripSearchBigSmallYes.Name = "toolStripSearchBigSmallYes";
            this.toolStripSearchBigSmallYes.Size = new System.Drawing.Size(134, 22);
            this.toolStripSearchBigSmallYes.Text = "Match case";
            // 
            // toolStripButtonCloseSearch
            // 
            this.toolStripButtonCloseSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonCloseSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCloseSearch.Image = global::CryptotextEditor.Properties.Resources.cross;
            this.toolStripButtonCloseSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseSearch.Name = "toolStripButtonCloseSearch";
            this.toolStripButtonCloseSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCloseSearch.Text = " X ";
            this.toolStripButtonCloseSearch.Click += new System.EventHandler(this.toolStripButtonCloseSearch_Click);
            // 
            // toolStripAES
            // 
            this.toolStripAES.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.toolStripAES.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAesEnc,
            this.toolStripTextBoxAESPassphrase,
            this.toolStripButtonAESencrypt,
            this.toolStripButtonAESdecrypt,
            this.toolStripButtonCloseAES});
            this.toolStripAES.Location = new System.Drawing.Point(0, 49);
            this.toolStripAES.Name = "toolStripAES";
            this.toolStripAES.Size = new System.Drawing.Size(492, 25);
            this.toolStripAES.TabIndex = 4;
            this.toolStripAES.Text = "toolStrip1";
            this.toolStripAES.Visible = false;
            // 
            // toolStripLabelAesEnc
            // 
            this.toolStripLabelAesEnc.Name = "toolStripLabelAesEnc";
            this.toolStripLabelAesEnc.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabelAesEnc.Text = "AES   Passphrase: ";
            // 
            // toolStripTextBoxAESPassphrase
            // 
            this.toolStripTextBoxAESPassphrase.MaxLength = 48;
            this.toolStripTextBoxAESPassphrase.Name = "toolStripTextBoxAESPassphrase";
            this.toolStripTextBoxAESPassphrase.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxAESPassphrase.TextChanged += new System.EventHandler(this.toolStripTextBoxAESPassphrase_TextChanged);
            // 
            // toolStripButtonAESencrypt
            // 
            this.toolStripButtonAESencrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAESencrypt.Enabled = false;
            this.toolStripButtonAESencrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAESencrypt.Name = "toolStripButtonAESencrypt";
            this.toolStripButtonAESencrypt.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonAESencrypt.Text = " Encrypt ";
            this.toolStripButtonAESencrypt.Click += new System.EventHandler(this.toolStripButtonAESencrypt_Click);
            // 
            // toolStripButtonAESdecrypt
            // 
            this.toolStripButtonAESdecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAESdecrypt.Enabled = false;
            this.toolStripButtonAESdecrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAESdecrypt.Name = "toolStripButtonAESdecrypt";
            this.toolStripButtonAESdecrypt.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonAESdecrypt.Text = " Decrypt ";
            this.toolStripButtonAESdecrypt.Click += new System.EventHandler(this.toolStripButtonAESdecrypt_Click);
            // 
            // toolStripButtonCloseAES
            // 
            this.toolStripButtonCloseAES.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonCloseAES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCloseAES.Image = global::CryptotextEditor.Properties.Resources.cross;
            this.toolStripButtonCloseAES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseAES.Name = "toolStripButtonCloseAES";
            this.toolStripButtonCloseAES.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCloseAES.Text = " X ";
            this.toolStripButtonCloseAES.Click += new System.EventHandler(this.toolStripButtonCloseAES_Click);
            // 
            // notifyIconCryptotextEditor
            // 
            this.notifyIconCryptotextEditor.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconCryptotextEditor.Icon")));
            this.notifyIconCryptotextEditor.Text = "Cryptotext Editor";
            this.notifyIconCryptotextEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconCryptotextEditor_MouseClick);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsNew,
            this.mtsOpen,
            this.mtsSave,
            this.mtsProperties,
            this.toolStripSeparator10,
            this.mtsUndo,
            this.mtsRedo,
            this.toolStripSeparator11,
            this.mtsCut,
            this.mtsCopy,
            this.mtsPaste,
            this.toolStripSeparator12,
            this.mtsSearch,
            this.mtsFont,
            this.toolStripSeparator13,
            this.mtsAES,
            this.toolStripSeparator15,
            this.mtsBase64encode,
            this.mtsBase64decode,
            this.toolStripSeparator14,
            this.mtsLeetspeak});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(492, 25);
            this.MainToolStrip.TabIndex = 5;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // mtsNew
            // 
            this.mtsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsNew.Image = global::CryptotextEditor.Properties.Resources.g6247;
            this.mtsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsNew.Name = "mtsNew";
            this.mtsNew.Size = new System.Drawing.Size(23, 22);
            this.mtsNew.Text = "New";
            this.mtsNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // mtsOpen
            // 
            this.mtsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsOpen.Image = global::CryptotextEditor.Properties.Resources.g5442;
            this.mtsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsOpen.Name = "mtsOpen";
            this.mtsOpen.Size = new System.Drawing.Size(23, 22);
            this.mtsOpen.Text = "Open";
            this.mtsOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // mtsSave
            // 
            this.mtsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsSave.Image = global::CryptotextEditor.Properties.Resources.g5969;
            this.mtsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsSave.Name = "mtsSave";
            this.mtsSave.Size = new System.Drawing.Size(23, 22);
            this.mtsSave.Text = "Save";
            this.mtsSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // mtsProperties
            // 
            this.mtsProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsProperties.Enabled = false;
            this.mtsProperties.Image = global::CryptotextEditor.Properties.Resources.g6231;
            this.mtsProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsProperties.Name = "mtsProperties";
            this.mtsProperties.Size = new System.Drawing.Size(23, 22);
            this.mtsProperties.Text = "CTXT properties";
            this.mtsProperties.Click += new System.EventHandler(this.MenuItemFileProperties_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // mtsUndo
            // 
            this.mtsUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsUndo.Enabled = false;
            this.mtsUndo.Image = global::CryptotextEditor.Properties.Resources.g5935;
            this.mtsUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsUndo.Name = "mtsUndo";
            this.mtsUndo.Size = new System.Drawing.Size(23, 22);
            this.mtsUndo.Text = "Undo";
            this.mtsUndo.Click += new System.EventHandler(this.MenuItemEditUndo_Click);
            // 
            // mtsRedo
            // 
            this.mtsRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsRedo.Enabled = false;
            this.mtsRedo.Image = global::CryptotextEditor.Properties.Resources.g5925;
            this.mtsRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsRedo.Name = "mtsRedo";
            this.mtsRedo.Size = new System.Drawing.Size(23, 22);
            this.mtsRedo.Text = "Redo";
            this.mtsRedo.Click += new System.EventHandler(this.MenuItemEditRedo_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // mtsCut
            // 
            this.mtsCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsCut.Enabled = false;
            this.mtsCut.Image = global::CryptotextEditor.Properties.Resources.g5889;
            this.mtsCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsCut.Name = "mtsCut";
            this.mtsCut.Size = new System.Drawing.Size(23, 22);
            this.mtsCut.Text = "Cut";
            this.mtsCut.Click += new System.EventHandler(this.MenuItemEditCut_Click);
            // 
            // mtsCopy
            // 
            this.mtsCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsCopy.Enabled = false;
            this.mtsCopy.Image = global::CryptotextEditor.Properties.Resources.g5782;
            this.mtsCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsCopy.Name = "mtsCopy";
            this.mtsCopy.Size = new System.Drawing.Size(23, 22);
            this.mtsCopy.Text = "Copy";
            this.mtsCopy.Click += new System.EventHandler(this.MenuItemEditCopy_Click);
            // 
            // mtsPaste
            // 
            this.mtsPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsPaste.Image = global::CryptotextEditor.Properties.Resources.g6024;
            this.mtsPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsPaste.Name = "mtsPaste";
            this.mtsPaste.Size = new System.Drawing.Size(23, 22);
            this.mtsPaste.Text = "Paste";
            this.mtsPaste.Click += new System.EventHandler(this.MenuItemEditPaste_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // mtsSearch
            // 
            this.mtsSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsSearch.Image = global::CryptotextEditor.Properties.Resources.g6038;
            this.mtsSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsSearch.Name = "mtsSearch";
            this.mtsSearch.Size = new System.Drawing.Size(23, 22);
            this.mtsSearch.Text = "Search";
            this.mtsSearch.Click += new System.EventHandler(this.MenuItemEditSearch_Click);
            // 
            // mtsFont
            // 
            this.mtsFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsFont.Image = global::CryptotextEditor.Properties.Resources.font;
            this.mtsFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsFont.Name = "mtsFont";
            this.mtsFont.Size = new System.Drawing.Size(23, 22);
            this.mtsFont.Text = "Font";
            this.mtsFont.Click += new System.EventHandler(this.MenuItemFormatFont_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // mtsAES
            // 
            this.mtsAES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsAES.Image = global::CryptotextEditor.Properties.Resources.text5442;
            this.mtsAES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsAES.Name = "mtsAES";
            this.mtsAES.Size = new System.Drawing.Size(23, 22);
            this.mtsAES.Text = "AES";
            this.mtsAES.Click += new System.EventHandler(this.MenuItemEncryptionAES_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // mtsBase64encode
            // 
            this.mtsBase64encode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsBase64encode.Image = global::CryptotextEditor.Properties.Resources.g5426;
            this.mtsBase64encode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsBase64encode.Name = "mtsBase64encode";
            this.mtsBase64encode.Size = new System.Drawing.Size(23, 22);
            this.mtsBase64encode.Text = "Base64 encode";
            this.mtsBase64encode.Click += new System.EventHandler(this.MenuItemEncryptionBase64encode_Click);
            // 
            // mtsBase64decode
            // 
            this.mtsBase64decode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsBase64decode.Image = global::CryptotextEditor.Properties.Resources.g5430;
            this.mtsBase64decode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsBase64decode.Name = "mtsBase64decode";
            this.mtsBase64decode.Size = new System.Drawing.Size(23, 22);
            this.mtsBase64decode.Text = "Base64 decode";
            this.mtsBase64decode.Click += new System.EventHandler(this.MenuItemEncryptionBase64decode_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // mtsLeetspeak
            // 
            this.mtsLeetspeak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mtsLeetspeak.Image = global::CryptotextEditor.Properties.Resources.text5446;
            this.mtsLeetspeak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mtsLeetspeak.Name = "mtsLeetspeak";
            this.mtsLeetspeak.Size = new System.Drawing.Size(23, 22);
            this.mtsLeetspeak.Text = "Leetspeak";
            this.mtsLeetspeak.Click += new System.EventHandler(this.MenuItemEncryptionLeetspeak_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 367);
            this.Controls.Add(this.toolStripSearch);
            this.Controls.Add(this.toolStripAES);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cryptotext Editor 0.10";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_Closing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.documentMenuStrip.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStripSearch.ResumeLayout(false);
            this.toolStripSearch.PerformLayout();
            this.toolStripAES.ResumeLayout(false);
            this.toolStripAES.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.Timer timerCheckFunctions;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelLines;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionArcs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionRot13;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSelected;
        private System.Windows.Forms.ToolStrip toolStripSearch;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchingString;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionAES;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseAES;
        private System.Windows.Forms.ContextMenuStrip documentMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFont;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSystemTray;
        private System.Windows.Forms.NotifyIcon notifyIconCryptotextEditor;
        public System.Windows.Forms.ToolStripMenuItem MenuItemFileLastOpened;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFileClose;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFileProperties;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditUndo;
        internal System.Windows.Forms.ToolStripSeparator MenuItemEditSeparator;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditCut;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditCopy;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditPaste;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditDelete;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditRedo;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditText;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditMarkupAll;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditTimeDate;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditSearch;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditTextUppercase;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditTextLowercase;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEditTextSentenceCase;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormat;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatWordWrap;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatDetectUrls;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatFont;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatAlig;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatReset;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatAligRight;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatAligLeft;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatAligCenter;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionBase64;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionBase64encode;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionBase64decode;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionByteEncode;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionByteDecode;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripDefault;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripFont;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripTextCase;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripCut;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripCopy;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripPaste;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripTextCaseUp;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripTextCaseLower;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripTextCaseSentence;
        internal System.Windows.Forms.ToolStripLabel toolStripLabelSearchFor;
        internal System.Windows.Forms.ToolStripSplitButton toolStripButtonSearch;
        internal System.Windows.Forms.ToolStripMenuItem toolStripSearchBigSmallYes;
        internal System.Windows.Forms.ToolStripButton toolStripButtonAESencrypt;
        internal System.Windows.Forms.ToolStripButton toolStripButtonAESdecrypt;
        internal System.Windows.Forms.ToolStripLabel toolStripLabelAesEnc;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLangEnglish;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLangGerman;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemLang;
        internal System.Windows.Forms.ToolStrip toolStripAES;
        internal System.Windows.Forms.ToolStripTextBox toolStripTextBoxAESPassphrase;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEncryptionLeetspeak;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatToolbox;
        private System.Windows.Forms.ToolStripButton mtsLeetspeak;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        internal System.Windows.Forms.ToolStripButton mtsNew;
        internal System.Windows.Forms.ToolStripButton mtsOpen;
        internal System.Windows.Forms.ToolStripButton mtsSave;
        internal System.Windows.Forms.ToolStripButton mtsProperties;
        internal System.Windows.Forms.ToolStripButton mtsUndo;
        internal System.Windows.Forms.ToolStripButton mtsRedo;
        internal System.Windows.Forms.ToolStripButton mtsCut;
        internal System.Windows.Forms.ToolStripButton mtsCopy;
        internal System.Windows.Forms.ToolStripButton mtsPaste;
        internal System.Windows.Forms.ToolStripButton mtsSearch;
        internal System.Windows.Forms.ToolStripButton mtsFont;
        internal System.Windows.Forms.ToolStripButton mtsBase64encode;
        internal System.Windows.Forms.ToolStripButton mtsBase64decode;
        private System.Windows.Forms.ToolStripButton mtsAES;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        internal System.Windows.Forms.RichTextBox Document;
        internal System.Windows.Forms.ToolStripMenuItem docMenuStripFontSize;
        private System.Windows.Forms.ToolStripMenuItem docMenuStripFontSize8;
        private System.Windows.Forms.ToolStripMenuItem docMenuStripFontSize12;
        private System.Windows.Forms.ToolStripMenuItem docMenuStripFontSize14;
        private System.Windows.Forms.ToolStripMenuItem docMenuStripFontSize16;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLangSpanish;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemFormatAutoSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHash;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHashMd5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHashSha1;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemHashFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        internal System.Windows.Forms.ToolStripMenuItem MenuItemEncryption;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHashSha256;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHashSha512;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHashSha384;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHashRipemd160;
    }
}

