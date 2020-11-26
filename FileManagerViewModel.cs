using Syncfusion.UI.Xaml.TreeView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    public class FileManagerViewModel
    {
        private ObservableCollection<FileManager> imageNodeInfo;
        public ObservableCollection<ExpandActionTrigger> ExpandActionTargets { get; set; }
        public ObservableCollection<ExpanderPosition> ExpanderPositions { get; set; }

        public ObservableCollection<SelectionMode> SelectionModes { get; set; }

        public FileManagerViewModel()
        {
            this.ExpandActionTargets = GetExpandActionTargets();
            this.ExpanderPositions = GetExpandPositions();
            SelectionModes = GetSelectionModes();
            GenerateSource();
            //this.Folders = GetFiles();
            this.Folders = GetFolders();
        }

        private ObservableCollection<SelectionMode> GetSelectionModes()
        {
            var expandActionTargets = new ObservableCollection<SelectionMode>();
            expandActionTargets.Add(SelectionMode.Single);
            expandActionTargets.Add(SelectionMode.SingleDeselect);
            expandActionTargets.Add(SelectionMode.Multiple);
            expandActionTargets.Add(SelectionMode.Extended);
            expandActionTargets.Add(SelectionMode.None);
            return expandActionTargets;
        }

        private ObservableCollection<ExpandActionTrigger> GetExpandActionTargets()
        {
            var expandActionTargets = new ObservableCollection<ExpandActionTrigger>();
            expandActionTargets.Add(ExpandActionTrigger.Expander);
            expandActionTargets.Add(ExpandActionTrigger.Node);
            return expandActionTargets;
        }
        private ObservableCollection<ExpanderPosition> GetExpandPositions()
        {
            var expanderPosition = new ObservableCollection<ExpanderPosition>();
            expanderPosition.Add(ExpanderPosition.Start);
            expanderPosition.Add(ExpanderPosition.End);
            return expanderPosition;
        }

        public ObservableCollection<FileManager> ImageNodeInfo
        {
            get { return imageNodeInfo; }
            set { this.imageNodeInfo = value; }
        }

        private void GenerateSource()
        {
            var nodeImageInfo = new ObservableCollection<FileManager>();
            Assembly assembly = typeof(FileManagerViewModel).GetTypeInfo().Assembly;
            var doc = new FileManager() { ItemName = "Documents"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_folder.png", assembly) */};
            var download = new FileManager() { ItemName = "Downloads"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_folder.png", assembly)*/ };
            var mp3 = new FileManager() { ItemName = "Music"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_folder.png", assembly)*/ };
            var pictures = new FileManager() { ItemName = "Pictures"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_folder.png", assembly)*/ };
            var video = new FileManager() { ItemName = "Videos"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_folder.png", assembly)*/ };

            var pollution = new FileManager() { ItemName = "Environmental Pollution.docx"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_word.png", assembly)*/ };
            var globalWarming = new FileManager() { ItemName = "Global Warming.ppt"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_ppt.png", assembly)*/ };
            var sanitation = new FileManager() { ItemName = "Sanitation.docx"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_word.png", assembly) */};
            var socialNetwork = new FileManager() { ItemName = "Social Network.pdf"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_pdf.png", assembly)*/ };
            var youthEmpower = new FileManager() { ItemName = "Youth Empowerment.pdf"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_pdf.png", assembly)*/ };

            var games = new FileManager() { ItemName = "Game.exe"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_exe.png", assembly)*/ };
            var tutorials = new FileManager() { ItemName = "Tutorials.zip"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_zip.png", assembly)*/ };
            var TypeScript = new FileManager() { ItemName = "TypeScript.7z"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_zip.png", assembly) */};
            var uiGuide = new FileManager() { ItemName = "UI-Guide.pdf"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_pdf.png", assembly) */};

            var song = new FileManager() { ItemName = "Goutiest"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_mp3.png", assembly)*/ };

            var camera = new FileManager() { ItemName = "Camera Roll"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_folder.png", assembly)*/ };
            var stone = new FileManager() { ItemName = "Stone.jpg"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_png.png", assembly)*/ };
            var wind = new FileManager() { ItemName = "Wind.jpg"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_png.png", assembly) */};

            var img0 = new FileManager() { ItemName = "WIN_20160726_094117.JPG"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_img0.png", assembly) */};
            var img1 = new FileManager() { ItemName = "WIN_20160726_094118.JPG"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_img1.png", assembly) */};

            var video1 = new FileManager() { ItemName = "Naturals.mp4"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_video.png", assembly) */};
            var video2 = new FileManager() { ItemName = "Wild.mpg"/*, ImageIcon = ImageSource.FromResource("GettingStartedBound.Icons.treeview_video.png", assembly) */};

            doc.SubFiles = new ObservableCollection<FileManager>
      {
         pollution,
         globalWarming,
         sanitation,
         socialNetwork,
         youthEmpower
      };

            download.SubFiles = new ObservableCollection<FileManager>
      {
         games,
         tutorials,
         TypeScript,
         uiGuide
      };

            mp3.SubFiles = new ObservableCollection<FileManager>
      {
         song
      };

            pictures.SubFiles = new ObservableCollection<FileManager>
      {
         camera,
         stone,
         wind
      };

            camera.SubFiles = new ObservableCollection<FileManager>
      {
         img0,
         img1
      };

            video.SubFiles = new ObservableCollection<FileManager>
      {
         video1,
         video2
      };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);
            imageNodeInfo = nodeImageInfo;
        }

        public ObservableCollection<Folder> Folders { get; set; }

        public ObservableCollection<File> Files { get; set; }

        public ObservableCollection<SubFile> SubFiles { get; set; }

        private ObservableCollection<Folder> GetFiles()
        {
            var nodeImageInfo = new ObservableCollection<Folder>();
            Assembly assembly = typeof(FileManagerViewModel).GetTypeInfo().Assembly;

            var doc = new Folder() { FileName = "Documents"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_folder.png", assembly) */};
            var download = new Folder() { FileName = "Downloads"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_folder.png", assembly) */};
            var mp3 = new Folder() { FileName = "Music"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_folder.png", assembly) */};
            var pictures = new Folder() { FileName = "Pictures"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_folder.png", assembly)*/ };
            var video = new Folder() { FileName = "Videos"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_folder.png", assembly)*/ };

            var pollution = new File() { FileName = "Environmental Pollution.docx"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_word.png", assembly)*/ };
            var globalWarming = new File() { FileName = "Global Warming.ppt"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_ppt.png", assembly)*/ };
            var sanitation = new File() { FileName = "Sanitation.docx"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_word.png", assembly) */};
            var socialNetwork = new File() { FileName = "Social Network.pdf"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_pdf.png", assembly)*/ };
            var youthEmpower = new File() { FileName = "Youth Empowerment.pdf"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_pdf.png", assembly)*/ };

            var games = new File() { FileName = "Game.exe"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_exe.png", assembly)*/ };
            var tutorials = new File() { FileName = "Tutorials.zip"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_zip.png", assembly)*/ };
            var typeScript = new File() { FileName = "TypeScript.7z"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_zip.png", assembly) */};
            var uiGuide = new File() { FileName = "UI-Guide.pdf"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_pdf.png", assembly)*/ };

            var song = new File() { FileName = "Gouttes"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_mp3.png", assembly)*/ };

            var camera = new File() { FileName = "Camera Roll"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_folder.png", assembly)*/ };
            var stone = new File() { FileName = "Stone.jpg"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_png.png", assembly) */};
            var wind = new File() { FileName = "Wind.jpg"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_png.png", assembly)*/ };

            var img0 = new SubFile() { FileName = "WIN_20160726_094117.JPG"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_img0.png", assembly) */};
            var img1 = new SubFile() { FileName = "WIN_20160726_094118.JPG"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_img1.png", assembly) */};

            var file1 = new SubFile1() { FileName = "File 1" };
            var file2 = new SubFile1() { FileName = "File 2" };
            var file3 = new SubFile1() { FileName = "File 3" };
            var file4 = new SubFile1() { FileName = "File 4" };
            var file5 = new SubFile1() { FileName = "File 5" };
            var file6 = new SubFile1() { FileName = "File 6" };

            var subFiles1 = new ObservableCollection<SubFile1>() { file1, file2, file3 };
            var subFiles2 = new ObservableCollection<SubFile1>() { file4, file5, file6 };
            //var subFiles3 = new ObservableCollection<SubFile1>() { file5, file6 };

            var doc1 = new SubFile() { FileName = "Document 1" };
            var doc2 = new SubFile() { FileName = "Document 2", SubFiles = subFiles2 };
            var doc3 = new SubFile() { FileName = "Document 3", SubFiles = subFiles1 };
            var doc4 = new SubFile() { FileName = "Document 4" };
            var doc5 = new SubFile() { FileName = "Document 5" };

            

            var video1 = new File() { FileName = "Naturals.mp4"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_video.png", assembly)*/ };
            var video2 = new File() { FileName = "Wild.mpeg"/*, ImageIcon = ImageSource.FromResource("SampleBrowser.SfTreeView.Icons.NodeWithImage.treeview_video.png", assembly)*/ };

            pollution.SubFiles = new ObservableCollection<SubFile>()
            {
                doc1,
                doc2,
                doc3
            };

            globalWarming.SubFiles = new ObservableCollection<SubFile>()
            {
                doc4,

                doc5
            };

            doc.Files = new ObservableCollection<File>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.Files = new ObservableCollection<File>
            {
                games,
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.Files = new ObservableCollection<File>
            {
                song
            };

            pictures.Files = new ObservableCollection<File>
            {
                camera,
                stone,
                wind
            };

            camera.SubFiles = new ObservableCollection<SubFile>
            {
                img0,
                img1
            };

            video.Files = new ObservableCollection<File>
            {
                video1,
                video2
            };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);
            return nodeImageInfo;
        }

        private ObservableCollection<Folder> GetFolders()
        {
            var item1 = new Item() { FileName = "Item1" };
            var item2 = new Item() { FileName = "Item2" };
            var item3 = new Item() { FileName = "Item3" };
            var item4 = new Item() { FileName = "Item4" };
            var item5 = new Item() { FileName = "Item5" };
            var item6 = new Item() { FileName = "Item6" };
            var item7 = new Item() { FileName = "Item7" };
            var item8 = new Item() { FileName = "Item8" };
            var item9 = new Item() { FileName = "Item9" };
            var item10 = new Item() { FileName = "Item10" };
            var item11 = new Item() { FileName = "Item11" };
            var item12 = new Item() { FileName = "Item12" };
            var item13 = new Item() { FileName = "Item13" };
            var item14 = new Item() { FileName = "Item14" };
            var item15 = new Item() { FileName = "Item15" };
            var item16 = new Item() { FileName = "Item16" };
            var item17 = new Item() { FileName = "Item17" };
            var item18 = new Item() { FileName = "Item18" };
            var item19 = new Item() { FileName = "Item19" };
            var item20 = new Item() { FileName = "Item20" };
            var item21 = new Item() { FileName = "Item21" };
            var item22 = new Item() { FileName = "Item22" };
            var item23 = new Item() { FileName = "Item23" };
            var item24 = new Item() { FileName = "Item24" };
            var item25 = new Item() { FileName = "Item25" };
            var item26 = new Item() { FileName = "Item26" };
            var item27 = new Item() { FileName = "Item27" };
            var item28 = new Item() { FileName = "Item28" };
            var item29 = new Item() { FileName = "Item29" };
            var item30 = new Item() { FileName = "Item30" };
            var item31 = new Item() { FileName = "Item31" };
            var item32 = new Item() { FileName = "Item32" };
            var item33 = new Item() { FileName = "Item33" };
            var item34 = new Item() { FileName = "Item34" };
            var item35 = new Item() { FileName = "Item35" };
            var item36 = new Item() { FileName = "Item36" };
            var item37 = new Item() { FileName = "Item37" };
            var item38 = new Item() { FileName = "Item38" };
            var item39 = new Item() { FileName = "Item39" };
            var item40 = new Item() { FileName = "Item40" };
            var item41 = new Item() { FileName = "Item41" };
            var item42 = new Item() { FileName = "Item42" };
            var item43 = new Item() { FileName = "Item43" };
            var item44 = new Item() { FileName = "Item44" };
            var item45 = new Item() { FileName = "Item45" };
            var item46 = new Item() { FileName = "Item46" };
            var item47 = new Item() { FileName = "Item47" };
            var item48 = new Item() { FileName = "Item48" };
            var item49 = new Item() { FileName = "Item49" };
            var item50 = new Item() { FileName = "Item50" };
            var item51 = new Item() { FileName = "Item51" };
            var item52 = new Item() { FileName = "Item52" };
            var item53 = new Item() { FileName = "Item53" };
            var item54 = new Item() { FileName = "Item54" };
            var item55 = new Item() { FileName = "Item55" };
            var item56 = new Item() { FileName = "Item56" };
            var item57 = new Item() { FileName = "Item57" };
            var item58 = new Item() { FileName = "Item58" };
            var item59 = new Item() { FileName = "Item59" };
            var item60 = new Item() { FileName = "Item60" };
            var item61 = new Item() { FileName = "Item61" };
            var item62 = new Item() { FileName = "Item62" };
            var item63 = new Item() { FileName = "Item63" };
            var item64 = new Item() { FileName = "Item64" };
            var item65 = new Item() { FileName = "Item65" };
            var item66 = new Item() { FileName = "Item66" };
            var item67 = new Item() { FileName = "Item67" };
            var item68 = new Item() { FileName = "Item68" };
            var item69 = new Item() { FileName = "Item69" };
            var item70 = new Item() { FileName = "Item70" };
            var item71 = new Item() { FileName = "Item71" };
            var item72 = new Item() { FileName = "Item72" };
            var item73 = new Item() { FileName = "Item73" };
            var item74 = new Item() { FileName = "Item74" };
            var item75 = new Item() { FileName = "Item75" };
            var item76 = new Item() { FileName = "Item76" };
            var item77 = new Item() { FileName = "Item77" };
            var item78 = new Item() { FileName = "Item78" };
            var item79 = new Item() { FileName = "Item79" };
            var item80 = new Item() { FileName = "Item80" };
            var item81 = new Item() { FileName = "Item81" };
            var item82 = new Item() { FileName = "Item82" };
            var item83 = new Item() { FileName = "Item83" };
            var item84 = new Item() { FileName = "Item84" };
            var item85 = new Item() { FileName = "Item85" };
            var item86 = new Item() { FileName = "Item86" };
            var item87 = new Item() { FileName = "Item87" };
            var item88 = new Item() { FileName = "Item88" };
            var item89 = new Item() { FileName = "Item89" };
            var item90 = new Item() { FileName = "Item90" };
            var item91 = new Item() { FileName = "Item91" };
            var item92 = new Item() { FileName = "Item92" };
            var item93 = new Item() { FileName = "Item93" };
            var item94 = new Item() { FileName = "Item94" };
            var item95 = new Item() { FileName = "Item95" };
            var item96 = new Item() { FileName = "Item96" };
            var item97 = new Item() { FileName = "Item97" };
            var item98 = new Item() { FileName = "Item98" };
            var item99 = new Item() { FileName = "Item99" };
            var item100 = new Item() { FileName = "Item100" };
            var item101 = new Item() { FileName = "Item101" };
            var item102 = new Item() { FileName = "Item102" };
            var item103 = new Item() { FileName = "Item103" };
            var item104 = new Item() { FileName = "Item104" };
            var item105 = new Item() { FileName = "Item105" };
            var item106 = new Item() { FileName = "Item106" };
            var item107 = new Item() { FileName = "Item107" };
            var item108 = new Item() { FileName = "Item108" };
            var item109 = new Item() { FileName = "Item109" };
            var item110 = new Item() { FileName = "Item110" };
            var item111 = new Item() { FileName = "Item111" };
            var item112 = new Item() { FileName = "Item112" };
            var item113 = new Item() { FileName = "Item113" };
            var item114 = new Item() { FileName = "Item114" };
            var item115 = new Item() { FileName = "Item115" };
            var item116 = new Item() { FileName = "Item116" };
            var item117 = new Item() { FileName = "Item117" };
            var item118 = new Item() { FileName = "Item118" };
            var item119 = new Item() { FileName = "Item119" };
            var item120 = new Item() { FileName = "Item120" };
            var item121 = new Item() { FileName = "Item121" };
            var item122 = new Item() { FileName = "Item122" };
            var item123 = new Item() { FileName = "Item123" };
            var item124 = new Item() { FileName = "Item124" };
            var item125 = new Item() { FileName = "Item125" };
            var item126 = new Item() { FileName = "Item126" };
            var item127 = new Item() { FileName = "Item127" };
            var item128 = new Item() { FileName = "Item128" };
            var item129 = new Item() { FileName = "Item129" };
            var item130 = new Item() { FileName = "Item130" };
            var item131 = new Item() { FileName = "Item131" };
            var item132 = new Item() { FileName = "Item132" };
            var item133 = new Item() { FileName = "Item133" };
            var item134 = new Item() { FileName = "Item134" };
            var item135 = new Item() { FileName = "Item135" };
            var item136 = new Item() { FileName = "Item136" };
            var item137 = new Item() { FileName = "Item137" };
            var item138 = new Item() { FileName = "Item138" };
            var item139 = new Item() { FileName = "Item139" };
            var item140 = new Item() { FileName = "Item140" };
            var item141 = new Item() { FileName = "Item141" };
            var item142 = new Item() { FileName = "Item142" };
            var item143 = new Item() { FileName = "Item143" };
            var item144 = new Item() { FileName = "Item144" };
            var item145 = new Item() { FileName = "Item145" };
            var item146 = new Item() { FileName = "Item146" };
            var item147 = new Item() { FileName = "Item147" };
            var item148 = new Item() { FileName = "Item148" };
            var item149 = new Item() { FileName = "Item149" };
            var item150 = new Item() { FileName = "Item150" };
            var item151 = new Item() { FileName = "Item151" };
            var item152 = new Item() { FileName = "Item152" };
            var item153 = new Item() { FileName = "Item153" };
            var item154 = new Item() { FileName = "Item154" };
            var item155 = new Item() { FileName = "Item155" };
            var item156 = new Item() { FileName = "Item156" };
            var item157 = new Item() { FileName = "Item157" };
            var item158 = new Item() { FileName = "Item158" };
            var item159 = new Item() { FileName = "Item159" };
            var item160 = new Item() { FileName = "Item160" };
            var item161 = new Item() { FileName = "Item161" };
            var item162 = new Item() { FileName = "Item162" };
            var item163 = new Item() { FileName = "Item163" };
            var item164 = new Item() { FileName = "Item164" };
            var item165 = new Item() { FileName = "Item165" };
            var item166 = new Item() { FileName = "Item166" };
            var item167 = new Item() { FileName = "Item167" };
            var item168 = new Item() { FileName = "Item168" };
            var item169 = new Item() { FileName = "Item169" };
            var item170 = new Item() { FileName = "Item170" };
            var item171 = new Item() { FileName = "Item171" };
            var item172 = new Item() { FileName = "Item172" };
            var item173 = new Item() { FileName = "Item173" };
            var item174 = new Item() { FileName = "Item174" };
            var item175 = new Item() { FileName = "Item175" };
            var item176 = new Item() { FileName = "Item176" };
            var item177 = new Item() { FileName = "Item177" };
            var item178 = new Item() { FileName = "Item178" };
            var item179 = new Item() { FileName = "Item179" };
            var item180 = new Item() { FileName = "Item180" };
            var item181 = new Item() { FileName = "Item181" };
            var item182 = new Item() { FileName = "Item182" };
            var item183 = new Item() { FileName = "Item183" };
            var item184 = new Item() { FileName = "Item184" };
            var item185 = new Item() { FileName = "Item185" };
            var item186 = new Item() { FileName = "Item186" };
            var item187 = new Item() { FileName = "Item187" };
            var item188 = new Item() { FileName = "Item188" };
            var item189 = new Item() { FileName = "Item189" };
            var item190 = new Item() { FileName = "Item190" };
            var item191 = new Item() { FileName = "Item191" };
            var item192 = new Item() { FileName = "Item192" };
            var item193 = new Item() { FileName = "Item193" };
            var item194 = new Item() { FileName = "Item194" };
            var item195 = new Item() { FileName = "Item195" };
            var item196 = new Item() { FileName = "Item196" };
            var item197 = new Item() { FileName = "Item197" };
            var item198 = new Item() { FileName = "Item198" };
            var item199 = new Item() { FileName = "Item199" };
            var item200 = new Item() { FileName = "Item200" };

            var items1 = new ObservableCollection<Item>() { item1, item2 };
            var items2 = new ObservableCollection<Item>() { item3, item4 };
            var items3 = new ObservableCollection<Item>() { item5, item6 };
            var items4 = new ObservableCollection<Item>() { item7, item8 };
            var items5 = new ObservableCollection<Item>() { item9, item10 };
            var items6 = new ObservableCollection<Item>() { item11, item12 };
            var items7 = new ObservableCollection<Item>() { item13, item14 };
            var items8 = new ObservableCollection<Item>() { item15, item16 };
            var items9 = new ObservableCollection<Item>() { item17, item18 };
            var items10 = new ObservableCollection<Item>() { item19, item20 };
            var items11 = new ObservableCollection<Item>() { item21, item22 };
            var items12 = new ObservableCollection<Item>() { item23, item24 };
            var items13 = new ObservableCollection<Item>() { item25, item26 };
            var items14 = new ObservableCollection<Item>() { item27, item28 };
            var items15 = new ObservableCollection<Item>() { item29, item30 };
            var items16 = new ObservableCollection<Item>() { item31, item32 };
            var items17 = new ObservableCollection<Item>() { item33, item34 };
            var items18 = new ObservableCollection<Item>() { item35, item36 };
            var items19 = new ObservableCollection<Item>() { item37, item38 };
            var items20 = new ObservableCollection<Item>() { item39, item40 };
            var items21 = new ObservableCollection<Item>() { item41, item42 };
            var items22 = new ObservableCollection<Item>() { item43, item44 };
            var items23 = new ObservableCollection<Item>() { item45, item46 };
            var items24 = new ObservableCollection<Item>() { item47, item48 };
            var items25 = new ObservableCollection<Item>() { item49, item50 };
            var items26 = new ObservableCollection<Item>() { item51, item52 };
            var items27 = new ObservableCollection<Item>() { item53, item54 };
            var items28 = new ObservableCollection<Item>() { item55, item56 };
            var items29 = new ObservableCollection<Item>() { item57, item58 };
            var items30 = new ObservableCollection<Item>() { item59, item60 };
            var items31 = new ObservableCollection<Item>() { item61, item62 };
            var items32 = new ObservableCollection<Item>() { item63, item64 };
            var items33 = new ObservableCollection<Item>() { item65, item66 };
            var items34 = new ObservableCollection<Item>() { item67, item68 };
            var items35 = new ObservableCollection<Item>() { item69, item70 };
            var items36 = new ObservableCollection<Item>() { item71, item72 };
            var items37 = new ObservableCollection<Item>() { item73, item74 };
            var items38 = new ObservableCollection<Item>() { item75, item76 };
            var items39 = new ObservableCollection<Item>() { item77, item78 };
            var items40 = new ObservableCollection<Item>() { item79, item80 };
            var items41 = new ObservableCollection<Item>() { item81, item82 };
            var items42 = new ObservableCollection<Item>() { item83, item84 };
            var items43 = new ObservableCollection<Item>() { item85, item86 };
            var items44 = new ObservableCollection<Item>() { item87, item88 };
            var items45 = new ObservableCollection<Item>() { item89, item90 };
            var items46 = new ObservableCollection<Item>() { item91, item92 };
            var items47 = new ObservableCollection<Item>() { item93, item94 };
            var items48 = new ObservableCollection<Item>() { item95, item96 };
            var items49 = new ObservableCollection<Item>() { item97, item98 };
            var items50 = new ObservableCollection<Item>() { item99, item100 };
            var items51 = new ObservableCollection<Item>() { item101, item102 };
            var items52 = new ObservableCollection<Item>() { item103, item104 };
            var items53 = new ObservableCollection<Item>() { item105, item106 };
            var items54 = new ObservableCollection<Item>() { item107, item108 };
            var items55 = new ObservableCollection<Item>() { item109, item110 };
            var items56 = new ObservableCollection<Item>() { item111, item112 };
            var items57 = new ObservableCollection<Item>() { item113, item114 };
            var items58 = new ObservableCollection<Item>() { item115, item116 };
            var items59 = new ObservableCollection<Item>() { item117, item118 };
            var items60 = new ObservableCollection<Item>() { item119, item120 };
            var items61 = new ObservableCollection<Item>() { item121, item122 };
            var items62 = new ObservableCollection<Item>() { item123, item124 };
            var items63 = new ObservableCollection<Item>() { item125, item126 };
            var items64 = new ObservableCollection<Item>() { item127, item128 };
            var items65 = new ObservableCollection<Item>() { item129, item130 };
            var items66 = new ObservableCollection<Item>() { item131, item132 };
            var items67 = new ObservableCollection<Item>() { item133, item134 };
            var items68 = new ObservableCollection<Item>() { item135, item136 };
            var items69 = new ObservableCollection<Item>() { item137, item138 };
            var items70 = new ObservableCollection<Item>() { item139, item140 };
            var items71 = new ObservableCollection<Item>() { item141, item142 };
            var items72 = new ObservableCollection<Item>() { item143, item144 };
            var items73 = new ObservableCollection<Item>() { item145, item146 };
            var items74 = new ObservableCollection<Item>() { item147, item148 };
            var items75 = new ObservableCollection<Item>() { item149, item150 };
            var items76 = new ObservableCollection<Item>() { item151, item152 };
            var items77 = new ObservableCollection<Item>() { item153, item154 };
            var items78 = new ObservableCollection<Item>() { item155, item156 };
            var items79 = new ObservableCollection<Item>() { item157, item158 };
            var items80 = new ObservableCollection<Item>() { item159, item160 };
            var items81 = new ObservableCollection<Item>() { item161, item162 };
            var items82 = new ObservableCollection<Item>() { item163, item164 };
            var items83 = new ObservableCollection<Item>() { item165, item166 };
            var items84 = new ObservableCollection<Item>() { item167, item168 };
            var items85 = new ObservableCollection<Item>() { item169, item170 };
            var items86 = new ObservableCollection<Item>() { item171, item172 };
            var items87 = new ObservableCollection<Item>() { item173, item174 };
            var items88 = new ObservableCollection<Item>() { item175, item176 };
            var items89 = new ObservableCollection<Item>() { item177, item178 };
            var items90 = new ObservableCollection<Item>() { item179, item180 };
            var items91 = new ObservableCollection<Item>() { item181, item182 };
            var items92 = new ObservableCollection<Item>() { item183, item184 };
            var items93 = new ObservableCollection<Item>() { item185, item186 };
            var items94 = new ObservableCollection<Item>() { item187, item188 };
            var items95 = new ObservableCollection<Item>() { item189, item190 };
            var items96 = new ObservableCollection<Item>() { item191, item192 };
            var items97 = new ObservableCollection<Item>() { item193, item194 };
            var items98 = new ObservableCollection<Item>() { item195, item196 };
            var items99 = new ObservableCollection<Item>() { item197, item198 };
            var items100 = new ObservableCollection<Item>() { item199, item200 };

            var subFile1 = new SubFile() { FileName = "SubFile1", Items = items1 };
            var subFile2 = new SubFile() { FileName = "SubFile2", Items = items2 };
            var subFile3 = new SubFile() { FileName = "SubFile3", Items = items3 };
            var subFile4 = new SubFile() { FileName = "SubFile4", Items = items4 };
            var subFile5 = new SubFile() { FileName = "SubFile5", Items = items5 };
            var subFile6 = new SubFile() { FileName = "SubFile6", Items = items6 };
            var subFile7 = new SubFile() { FileName = "SubFile7", Items = items7 };
            var subFile8 = new SubFile() { FileName = "SubFile8", Items = items8 };
            var subFile9 = new SubFile() { FileName = "SubFile9", Items = items9 };
            var subFile10 = new SubFile() { FileName = "SubFile10", Items = items10 };
            var subFile11 = new SubFile() { FileName = "SubFile11", Items = items11 };
            var subFile12 = new SubFile() { FileName = "SubFile12", Items = items12 };
            var subFile13 = new SubFile() { FileName = "SubFile13", Items = items13 };
            var subFile14 = new SubFile() { FileName = "SubFile14", Items = items14 };
            var subFile15 = new SubFile() { FileName = "SubFile15", Items = items15 };
            var subFile16 = new SubFile() { FileName = "SubFile16", Items = items16 };
            var subFile17 = new SubFile() { FileName = "SubFile17", Items = items17 };
            var subFile18 = new SubFile() { FileName = "SubFile18", Items = items18 };
            var subFile19 = new SubFile() { FileName = "SubFile19", Items = items19 };
            var subFile20 = new SubFile() { FileName = "SubFile20", Items = items20 };
            var subFile21 = new SubFile() { FileName = "SubFile21", Items = items21 };
            var subFile22 = new SubFile() { FileName = "SubFile22", Items = items22 };
            var subFile23 = new SubFile() { FileName = "SubFile23", Items = items23 };
            var subFile24 = new SubFile() { FileName = "SubFile24", Items = items24 };
            var subFile25 = new SubFile() { FileName = "SubFile25", Items = items25 };
            var subFile26 = new SubFile() { FileName = "SubFile26", Items = items26 };
            var subFile27 = new SubFile() { FileName = "SubFile27", Items = items27 };
            var subFile28 = new SubFile() { FileName = "SubFile28", Items = items28 };
            var subFile29 = new SubFile() { FileName = "SubFile29", Items = items29 };
            var subFile30 = new SubFile() { FileName = "SubFile30", Items = items30 };
            var subFile31 = new SubFile() { FileName = "SubFile31", Items = items31 };
            var subFile32 = new SubFile() { FileName = "SubFile32", Items = items32 };
            var subFile33 = new SubFile() { FileName = "SubFile33", Items = items33 };
            var subFile34 = new SubFile() { FileName = "SubFile34", Items = items34 };
            var subFile35 = new SubFile() { FileName = "SubFile35", Items = items35 };
            var subFile36 = new SubFile() { FileName = "SubFile36", Items = items36 };
            var subFile37 = new SubFile() { FileName = "SubFile37", Items = items37 };
            var subFile38 = new SubFile() { FileName = "SubFile38", Items = items38 };
            var subFile39 = new SubFile() { FileName = "SubFile39", Items = items39 };
            var subFile40 = new SubFile() { FileName = "SubFile40", Items = items40 };
            var subFile41 = new SubFile() { FileName = "SubFile41", Items = items41 };
            var subFile42 = new SubFile() { FileName = "SubFile42", Items = items42 };
            var subFile43 = new SubFile() { FileName = "SubFile43", Items = items43 };
            var subFile44 = new SubFile() { FileName = "SubFile44", Items = items44 };
            var subFile45 = new SubFile() { FileName = "SubFile45", Items = items45 };
            var subFile46 = new SubFile() { FileName = "SubFile46", Items = items46 };
            var subFile47 = new SubFile() { FileName = "SubFile47", Items = items47 };
            var subFile48 = new SubFile() { FileName = "SubFile48", Items = items48 };
            var subFile49 = new SubFile() { FileName = "SubFile49", Items = items49 };
            var subFile50 = new SubFile() { FileName = "SubFile50", Items = items50 };
            var subFile51 = new SubFile() { FileName = "SubFile51", Items = items51 };
            var subFile52 = new SubFile() { FileName = "SubFile52", Items = items52 };
            var subFile53 = new SubFile() { FileName = "SubFile53", Items = items53 };
            var subFile54 = new SubFile() { FileName = "SubFile54", Items = items54 };
            var subFile55 = new SubFile() { FileName = "SubFile55", Items = items55 };
            var subFile56 = new SubFile() { FileName = "SubFile56", Items = items56 };
            var subFile57 = new SubFile() { FileName = "SubFile57", Items = items57 };
            var subFile58 = new SubFile() { FileName = "SubFile58", Items = items58 };
            var subFile59 = new SubFile() { FileName = "SubFile59", Items = items59 };
            var subFile60 = new SubFile() { FileName = "SubFile60", Items = items60 };
            var subFile61 = new SubFile() { FileName = "SubFile61", Items = items61 };
            var subFile62 = new SubFile() { FileName = "SubFile62", Items = items62 };
            var subFile63 = new SubFile() { FileName = "SubFile63", Items = items63 };
            var subFile64 = new SubFile() { FileName = "SubFile64", Items = items64 };
            var subFile65 = new SubFile() { FileName = "SubFile65", Items = items65 };
            var subFile66 = new SubFile() { FileName = "SubFile66", Items = items66 };
            var subFile67 = new SubFile() { FileName = "SubFile67", Items = items67 };
            var subFile68 = new SubFile() { FileName = "SubFile68", Items = items68 };
            var subFile69 = new SubFile() { FileName = "SubFile69", Items = items69 };
            var subFile70 = new SubFile() { FileName = "SubFile70", Items = items70 };
            var subFile71 = new SubFile() { FileName = "SubFile71", Items = items71 };
            var subFile72 = new SubFile() { FileName = "SubFile72", Items = items72 };
            var subFile73 = new SubFile() { FileName = "SubFile73", Items = items73 };
            var subFile74 = new SubFile() { FileName = "SubFile74", Items = items74 };
            var subFile75 = new SubFile() { FileName = "SubFile75", Items = items75 };
            var subFile76 = new SubFile() { FileName = "SubFile76", Items = items76 };
            var subFile77 = new SubFile() { FileName = "SubFile77", Items = items77 };
            var subFile78 = new SubFile() { FileName = "SubFile78", Items = items78 };
            var subFile79 = new SubFile() { FileName = "SubFile79", Items = items79 };
            var subFile80 = new SubFile() { FileName = "SubFile80", Items = items80 };
            var subFile81 = new SubFile() { FileName = "SubFile81", Items = items81 };
            var subFile82 = new SubFile() { FileName = "SubFile82", Items = items82 };
            var subFile83 = new SubFile() { FileName = "SubFile83", Items = items83 };
            var subFile84 = new SubFile() { FileName = "SubFile84", Items = items84 };
            var subFile85 = new SubFile() { FileName = "SubFile85", Items = items85 };
            var subFile86 = new SubFile() { FileName = "SubFile86", Items = items86 };
            var subFile87 = new SubFile() { FileName = "SubFile87", Items = items87 };
            var subFile88 = new SubFile() { FileName = "SubFile88", Items = items88 };
            var subFile89 = new SubFile() { FileName = "SubFile89", Items = items89 };
            var subFile90 = new SubFile() { FileName = "SubFile90", Items = items90 };
            var subFile91 = new SubFile() { FileName = "SubFile91", Items = items91 };
            var subFile92 = new SubFile() { FileName = "SubFile92", Items = items92 };
            var subFile93 = new SubFile() { FileName = "SubFile93", Items = items93 };
            var subFile94 = new SubFile() { FileName = "SubFile94", Items = items94 };
            var subFile95 = new SubFile() { FileName = "SubFile95", Items = items95 };
            var subFile96 = new SubFile() { FileName = "SubFile96", Items = items96 };
            var subFile97 = new SubFile() { FileName = "SubFile97", Items = items97 };
            var subFile98 = new SubFile() { FileName = "SubFile98", Items = items98 };
            var subFile99 = new SubFile() { FileName = "SubFile99", Items = items99 };
            var subFile100 = new SubFile() { FileName = "SubFile100", Items = items100 };

            var subFiles1 = new ObservableCollection<SubFile>() { subFile1, subFile2 };
            var subFiles2 = new ObservableCollection<SubFile>() { subFile3, subFile4 };
            var subFiles3 = new ObservableCollection<SubFile>() { subFile5, subFile6 };
            var subFiles4 = new ObservableCollection<SubFile>() { subFile7, subFile8 };
            var subFiles5 = new ObservableCollection<SubFile>() { subFile9, subFile10 };
            var subFiles6 = new ObservableCollection<SubFile>() { subFile11, subFile12 };
            var subFiles7 = new ObservableCollection<SubFile>() { subFile13, subFile14 };
            var subFiles8 = new ObservableCollection<SubFile>() { subFile15, subFile16 };
            var subFiles9 = new ObservableCollection<SubFile>() { subFile17, subFile18 };
            var subFiles10 = new ObservableCollection<SubFile>() { subFile19, subFile20 };
            var subFiles11 = new ObservableCollection<SubFile>() { subFile21, subFile22 };
            var subFiles12 = new ObservableCollection<SubFile>() { subFile23, subFile24 };
            var subFiles13 = new ObservableCollection<SubFile>() { subFile25, subFile26 };
            var subFiles14 = new ObservableCollection<SubFile>() { subFile27, subFile28 };
            var subFiles15 = new ObservableCollection<SubFile>() { subFile29, subFile30 };
            var subFiles16 = new ObservableCollection<SubFile>() { subFile31, subFile32 };
            var subFiles17 = new ObservableCollection<SubFile>() { subFile33, subFile34 };
            var subFiles18 = new ObservableCollection<SubFile>() { subFile35, subFile36 };
            var subFiles19 = new ObservableCollection<SubFile>() { subFile37, subFile38 };
            var subFiles20 = new ObservableCollection<SubFile>() { subFile39, subFile40 };
            var subFiles21 = new ObservableCollection<SubFile>() { subFile41, subFile42 };
            var subFiles22 = new ObservableCollection<SubFile>() { subFile43, subFile44 };
            var subFiles23 = new ObservableCollection<SubFile>() { subFile45, subFile46 };
            var subFiles24 = new ObservableCollection<SubFile>() { subFile47, subFile48 };
            var subFiles25 = new ObservableCollection<SubFile>() { subFile49, subFile50 };
            var subFiles26 = new ObservableCollection<SubFile>() { subFile51, subFile52 };
            var subFiles27 = new ObservableCollection<SubFile>() { subFile53, subFile54 };
            var subFiles28 = new ObservableCollection<SubFile>() { subFile55, subFile56 };
            var subFiles29 = new ObservableCollection<SubFile>() { subFile57, subFile58 };
            var subFiles30 = new ObservableCollection<SubFile>() { subFile59, subFile60 };
            var subFiles31 = new ObservableCollection<SubFile>() { subFile61, subFile62 };
            var subFiles32 = new ObservableCollection<SubFile>() { subFile63, subFile64 };
            var subFiles33 = new ObservableCollection<SubFile>() { subFile65, subFile66 };
            var subFiles34 = new ObservableCollection<SubFile>() { subFile67, subFile68 };
            var subFiles35 = new ObservableCollection<SubFile>() { subFile69, subFile70 };
            var subFiles36 = new ObservableCollection<SubFile>() { subFile71, subFile72 };
            var subFiles37 = new ObservableCollection<SubFile>() { subFile73, subFile74 };
            var subFiles38 = new ObservableCollection<SubFile>() { subFile75, subFile76 };
            var subFiles39 = new ObservableCollection<SubFile>() { subFile77, subFile78 };
            var subFiles40 = new ObservableCollection<SubFile>() { subFile79, subFile80 };
            var subFiles41 = new ObservableCollection<SubFile>() { subFile81, subFile82 };
            var subFiles42 = new ObservableCollection<SubFile>() { subFile83, subFile84 };
            var subFiles43 = new ObservableCollection<SubFile>() { subFile85, subFile86 };
            var subFiles44 = new ObservableCollection<SubFile>() { subFile87, subFile88 };
            var subFiles45 = new ObservableCollection<SubFile>() { subFile89, subFile90 };
            var subFiles46 = new ObservableCollection<SubFile>() { subFile91, subFile92 };
            var subFiles47 = new ObservableCollection<SubFile>() { subFile93, subFile94 };
            var subFiles48 = new ObservableCollection<SubFile>() { subFile95, subFile96 };
            var subFiles49 = new ObservableCollection<SubFile>() { subFile97, subFile98 };
            var subFiles50 = new ObservableCollection<SubFile>() { subFile99, subFile100 };

            var file1 = new File() { FileName = "File1", SubFiles = subFiles1 };
            var file2 = new File() { FileName = "File2", SubFiles = subFiles2 };
            var file3 = new File() { FileName = "File3", SubFiles = subFiles3 };
            var file4 = new File() { FileName = "File4", SubFiles = subFiles4 };
            var file5 = new File() { FileName = "File5", SubFiles = subFiles5 };
            var file6 = new File() { FileName = "File6", SubFiles = subFiles6 };
            var file7 = new File() { FileName = "File7", SubFiles = subFiles7 };
            var file8 = new File() { FileName = "File8", SubFiles = subFiles8 };
            var file9 = new File() { FileName = "File9", SubFiles = subFiles9 };
            var file10 = new File() { FileName = "File10", SubFiles = subFiles10 };
            var file11 = new File() { FileName = "File11", SubFiles = subFiles11 };
            var file12 = new File() { FileName = "File12", SubFiles = subFiles12 };
            var file13 = new File() { FileName = "File13", SubFiles = subFiles13 };
            var file14 = new File() { FileName = "File14", SubFiles = subFiles14 };
            var file15 = new File() { FileName = "File15", SubFiles = subFiles15 };
            var file16 = new File() { FileName = "File16", SubFiles = subFiles16 };
            var file17 = new File() { FileName = "File17", SubFiles = subFiles17 };
            var file18 = new File() { FileName = "File18", SubFiles = subFiles18 };
            var file19 = new File() { FileName = "File19", SubFiles = subFiles19 };
            var file20 = new File() { FileName = "File20", SubFiles = subFiles20 };
            var file21 = new File() { FileName = "File21", SubFiles = subFiles21 };
            var file22 = new File() { FileName = "File22", SubFiles = subFiles22 };
            var file23 = new File() { FileName = "File23", SubFiles = subFiles23 };
            var file24 = new File() { FileName = "File24", SubFiles = subFiles24 };
            var file25 = new File() { FileName = "File25", SubFiles = subFiles25 };
            var file26 = new File() { FileName = "File26", SubFiles = subFiles26 };
            var file27 = new File() { FileName = "File27", SubFiles = subFiles27 };
            var file28 = new File() { FileName = "File28", SubFiles = subFiles28 };
            var file29 = new File() { FileName = "File29", SubFiles = subFiles29 };
            var file30 = new File() { FileName = "File30", SubFiles = subFiles30 };
            var file31 = new File() { FileName = "File31", SubFiles = subFiles31 };
            var file32 = new File() { FileName = "File32", SubFiles = subFiles32 };
            var file33 = new File() { FileName = "File33", SubFiles = subFiles33 };
            var file34 = new File() { FileName = "File34", SubFiles = subFiles34 };
            var file35 = new File() { FileName = "File35", SubFiles = subFiles35 };
            var file36 = new File() { FileName = "File36", SubFiles = subFiles36 };
            var file37 = new File() { FileName = "File37", SubFiles = subFiles37 };
            var file38 = new File() { FileName = "File38", SubFiles = subFiles38 };
            var file39 = new File() { FileName = "File39", SubFiles = subFiles39 };
            var file40 = new File() { FileName = "File40", SubFiles = subFiles40 };
            var file41 = new File() { FileName = "File41", SubFiles = subFiles41 };
            var file42 = new File() { FileName = "File42", SubFiles = subFiles42 };
            var file43 = new File() { FileName = "File43", SubFiles = subFiles43 };
            var file44 = new File() { FileName = "File44", SubFiles = subFiles44 };
            var file45 = new File() { FileName = "File45", SubFiles = subFiles45 };
            var file46 = new File() { FileName = "File46", SubFiles = subFiles46 };
            var file47 = new File() { FileName = "File47", SubFiles = subFiles47 };
            var file48 = new File() { FileName = "File48", SubFiles = subFiles48 };
            var file49 = new File() { FileName = "File49", SubFiles = subFiles49 };
            var file50 = new File() { FileName = "File50", SubFiles = subFiles50 };

            var files1 = new ObservableCollection<File>()
            {
                file1,file2,file3,file4,file5
            };
            var files2 = new ObservableCollection<File>()
            {
                file6,file7,file8,file9,file10
            };
            var files3 = new ObservableCollection<File>()
            {
                file11,file12,file13,file14,file15
            };
            var files4 = new ObservableCollection<File>()
            {
                file16,file17,file18,file19,file20
            };
            var files5 = new ObservableCollection<File>()
            {
                file21,file22,file23,file24,file25
            };
            var files6 = new ObservableCollection<File>()
            {
                file26,file27,file28,file29,file30
            };
            var files7 = new ObservableCollection<File>()
            {
                file31,file32,file33,file34,file35
            };
            var files8 = new ObservableCollection<File>()
            {
                file36,file37,file38,file39,file40
            };
            var files9 = new ObservableCollection<File>()
            {
                file41,file42,file43,file44,file45
            };
            var files10 = new ObservableCollection<File>()
            {
                file46,file47,file48,file49,file50
            };

            var folder1 = new Folder() { FileName = "Folder1", Files = files1 };
            var folder2 = new Folder() { FileName = "Folder2", Files = files2 };
            var folder3 = new Folder() { FileName = "Folder3", Files = files3 };
            var folder4 = new Folder() { FileName = "Folder4", Files = files4 };
            var folder5 = new Folder() { FileName = "Folder5", Files = files5 };
            var folder6 = new Folder() { FileName = "Folder6", Files = files6 };
            var folder7 = new Folder() { FileName = "Folder7", Files = files7 };
            var folder8 = new Folder() { FileName = "Folder8", Files = files8 };
            var folder9 = new Folder() { FileName = "Folder9", Files = files9 };
            var folder10 = new Folder() { FileName = "Folder10", Files = files10 };

            var folders = new ObservableCollection<Folder>();
            folders.Add(folder1);
            folders.Add(folder2);
            folders.Add(folder3);
            folders.Add(folder4);
            folders.Add(folder5);
            //folders.Add(folder6);
            //folders.Add(folder7);
            //folders.Add(folder8);
            //folders.Add(folder9);
            //folders.Add(folder10);
            return folders;
        }
    }
}
