using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApplicationXmlDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"D:\작업중 자료\20161024 다국어지원\ZF1704.srf";
            string path = @"D:\작업중 자료\20161024 다국어지원\Menu.xml";
            StringBuilder sbuilder = new StringBuilder();
            //DeSerialize
            string xml = File.ReadAllText(path);
            //Application catalog1 = xml.ParseXML<Application>();



            //1.Menu Load
            MenuCollection.Application application = new MenuCollection.Application();
            string xmlContent;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XDocument xDoc = XDocument.Load(fs);
                xmlContent = xDoc.ToString();
            }

            //스트링의 경우 se -> de
            using (TextReader reader = new StringReader(xmlContent))
            {   
                XmlSerializer serializer = new XmlSerializer(typeof(MenuCollection.Application));
                application = (MenuCollection.Application)serializer.Deserialize(reader);
            }

            //Set 해보자
            Dictionary<string, string> captionList = new Dictionary<string,string>();
            captionList.Add("ZF0000", "큐피엘~");
            //captionList.Add("ZF00001", "STANDARD INFO");
            //captionList.Add("ZF0200", "Item INFO");
            //captionList.Add("ZF0110Z", "Type Registration");

            captionList.ToList().ForEach(x => application.Menus.Where(w => w.Menu.UniqueID.Equals(x.Key)).FirstOrDefault().Menu.String = x.Value);


            ////2.Filterling --Get
            //MenuCollection.ApplicationActionMenuMenus
            var applicationAction = application.Menus.Where(x => x.type.Equals("add")).ToList<MenuCollection.ApplicationAction>();

            applicationAction.ForEach(x => Recursive(x));

            // wrap XmlTextWriter into a using block because it supports IDisposable
            using (XmlTextWriter tw = new XmlTextWriter(@"D:\작업중 자료\20161024 다국어지원\NewMenu.xml", Encoding.UTF8))
            {
                //줄바꿈 적용
                tw.Formatting = Formatting.Indented;
                tw.Indentation = 4;

                // create an XmlSerializer for your class type
                XmlSerializer xs = new XmlSerializer(typeof(MenuCollection.Application));

                xs.Serialize(tw, application);

                Console.WriteLine("NewMenu.xml 생성 완료");
            }





            ////1.Application Load
            //Application catalog1 = new Application();
            //string xmlContent;
            //using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            //{
            //    XDocument xDoc = XDocument.Load(fs);
            //    xmlContent = xDoc.ToString();
            //}

            ////스트링의 경우 se -> de
            //using (TextReader reader = new StringReader(xmlContent))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(FormCollection.Application));
            //    catalog1 = (FormCollection.Application)serializer.Deserialize(reader);
            //}


            ////2.Filterling
            //var cnc = catalog1.forms.action.form.Items.Where(x => x.GetType().Equals(typeof(FormCollection.ApplicationFormsActionFormItems)));

            //var items = cnc.Where(x => (x as FormCollection.ApplicationFormsActionFormItems).action.type == "add").FirstOrDefault();

            ////3.SET Application Class
            //(items as FormCollection.ApplicationFormsActionFormItems).action.item.ToList<FormCollection.ApplicationFormsActionFormItemsActionItem>()
            //    .Where(x => x.specific.caption != null)
            //    .Where(x => x.specific.caption.Equals("위치")).FirstOrDefault()
            //    .specific.caption = "Location";

            //(items as FormCollection.ApplicationFormsActionFormItems).action.item.ToList<FormCollection.ApplicationFormsActionFormItemsActionItem>()
            //    .Where(x => x.specific.caption != null)
            //    .Where(x => x.uid.Equals("Item_7")).FirstOrDefault()
            //    .specific.caption = "Maker";

            ////4. out
            //(items as FormCollection.ApplicationFormsActionFormItems).action.item.ToList<FormCollection.ApplicationFormsActionFormItemsActionItem>()
            //    .ForEach(x => sbuilder.AppendLine(string.Format("{0}:{1}",x.uid, x.specific.caption)));





            //Console.WriteLine(sbuilder);


        }

        private static void Recursive(MenuCollection.ApplicationAction appAction)
        {
            MenuCollection.ApplicationActionMenu appMenu = appAction.Menu;

            Console.WriteLine(string.Format("{0}, {1}", appMenu.UniqueID, appMenu.String));

            if (appMenu.Menus.Count() > 0)
            {
                foreach (MenuCollection.ApplicationActionMenuMenus menus in appMenu.Menus)
                {
                    
                    //MenuCollection.ApplicationActionMenu menus_menu = menus.Action.Menu;
                    foreach (MenuCollection.ApplicationActionMenuMenusActionMenu menus_menu in menus.Action.Menu)
                    {
                        Console.WriteLine(string.Format("-{0}, {1}", menus_menu.UniqueID, menus_menu.String));

                        if (menus_menu.Menus == null)
                            continue;

                        if (menus_menu.Menus.Count() > 0)
                        {
                            foreach (MenuCollection.ApplicationActionMenuMenusActionMenuMenus men in menus_menu.Menus)
                            {
                                //MenuCollection.ApplicationActionMenu men_menu = men.Action.Menu;
                                foreach (MenuCollection.ApplicationActionMenuMenusActionMenuMenusActionMenu men_menu in men.Action.Menu)
                                {
                                    Console.WriteLine(string.Format("--{0}, {1}", men_menu.UniqueID, men_menu.String));

                                    if (men_menu.Menus == null)
                                        continue;

                                    //Action type="add"가 있는데 Menu가 없을때 예외처리
                                    if (men_menu.Menus.Action.Menu == null)
                                        continue;

                                    foreach (MenuCollection.ApplicationActionMenuMenusActionMenuMenusActionMenuMenusActionMenu me_menu in men_menu.Menus.Action.Menu)
                                    {
                                        Console.WriteLine(string.Format("---{0}, {1}", me_menu.UniqueID, me_menu.String));

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


        //private void PrintRecursive(TreeNode treeNode)
        //{
        //    // Print the node.
        //    System.Diagnostics.Debug.WriteLine(treeNode.Text);
        //    MessageBox.Show(treeNode.Text);
        //    // Print each node recursively.
        //    foreach (TreeNode tn in treeNode.Nodes)
        //    {
        //        PrintRecursive(tn);
        //    }
        //}

        //// Call the procedure using the TreeView.
        //private void CallRecursive(TreeView treeView)
        //{
        //    // Print each node recursively.
        //    TreeNodeCollection nodes = treeView.Nodes;
        //    foreach (TreeNode n in nodes)
        //    {
        //        PrintRecursive(n);
        //    }
        //}



//Serialize -> Deserialize
//Application catalog1 = new Application();

//using (TextReader reader = new StreamReader(path))
//{
//    XmlSerializer serializer = new XmlSerializer(typeof(Application));
//    catalog1 = (Application)serializer.Deserialize(reader);
//}
