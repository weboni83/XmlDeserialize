using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationXmlDeserialize
{
    public class MenuCollection
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Application
        {

            private ApplicationAction[] menusField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Action", IsNullable = false)]
            public ApplicationAction[] Menus
            {
                get
                {
                    return this.menusField;
                }
                set
                {
                    this.menusField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationAction
        {

            private ApplicationActionMenu menuField;

            private string typeField;

            /// <remarks/>
            public ApplicationActionMenu Menu
            {
                get
                {
                    return this.menuField;
                }
                set
                {
                    this.menuField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenu
        {

            private ApplicationActionMenuMenus[] menusField;

            private byte checkedField;

            private byte enabledField;

            private string fatherUIDField;

            private byte positionField;

            private string stringField;

            private byte typeField;

            private string uniqueIDField;

            private string imageField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Menus")]
            public ApplicationActionMenuMenus[] Menus
            {
                get
                {
                    return this.menusField;
                }
                set
                {
                    this.menusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Checked
            {
                get
                {
                    return this.checkedField;
                }
                set
                {
                    this.checkedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FatherUID
            {
                get
                {
                    return this.fatherUIDField;
                }
                set
                {
                    this.fatherUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string String
            {
                get
                {
                    return this.stringField;
                }
                set
                {
                    this.stringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UniqueID
            {
                get
                {
                    return this.uniqueIDField;
                }
                set
                {
                    this.uniqueIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Image
            {
                get
                {
                    return this.imageField;
                }
                set
                {
                    this.imageField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenus
        {

            private ApplicationActionMenuMenusAction actionField;

            /// <remarks/>
            public ApplicationActionMenuMenusAction Action
            {
                get
                {
                    return this.actionField;
                }
                set
                {
                    this.actionField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusAction
        {

            private ApplicationActionMenuMenusActionMenu[] menuField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Menu")]
            public ApplicationActionMenuMenusActionMenu[] Menu
            {
                get
                {
                    return this.menuField;
                }
                set
                {
                    this.menuField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenu
        {

            private ApplicationActionMenuMenusActionMenuMenus[] menusField;

            private byte checkedField;

            private byte enabledField;

            private string fatherUIDField;

            private byte positionField;

            private string stringField;

            private byte typeField;

            private string uniqueIDField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Menus")]
            public ApplicationActionMenuMenusActionMenuMenus[] Menus
            {
                get
                {
                    return this.menusField;
                }
                set
                {
                    this.menusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Checked
            {
                get
                {
                    return this.checkedField;
                }
                set
                {
                    this.checkedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FatherUID
            {
                get
                {
                    return this.fatherUIDField;
                }
                set
                {
                    this.fatherUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string String
            {
                get
                {
                    return this.stringField;
                }
                set
                {
                    this.stringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UniqueID
            {
                get
                {
                    return this.uniqueIDField;
                }
                set
                {
                    this.uniqueIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenuMenus
        {

            private ApplicationActionMenuMenusActionMenuMenusAction actionField;

            /// <remarks/>
            public ApplicationActionMenuMenusActionMenuMenusAction Action
            {
                get
                {
                    return this.actionField;
                }
                set
                {
                    this.actionField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenuMenusAction
        {

            private ApplicationActionMenuMenusActionMenuMenusActionMenu[] menuField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Menu")]
            public ApplicationActionMenuMenusActionMenuMenusActionMenu[] Menu
            {
                get
                {
                    return this.menuField;
                }
                set
                {
                    this.menuField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenuMenusActionMenu
        {

            private ApplicationActionMenuMenusActionMenuMenusActionMenuMenus menusField;

            private byte checkedField;

            private byte enabledField;

            private string fatherUIDField;

            private byte positionField;

            private string stringField;

            private byte typeField;

            private string uniqueIDField;

            private string stringField1;

            /// <remarks/>
            public ApplicationActionMenuMenusActionMenuMenusActionMenuMenus Menus
            {
                get
                {
                    return this.menusField;
                }
                set
                {
                    this.menusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Checked
            {
                get
                {
                    return this.checkedField;
                }
                set
                {
                    this.checkedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FatherUID
            {
                get
                {
                    return this.fatherUIDField;
                }
                set
                {
                    this.fatherUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string String
            {
                get
                {
                    return this.stringField;
                }
                set
                {
                    this.stringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UniqueID
            {
                get
                {
                    return this.uniqueIDField;
                }
                set
                {
                    this.uniqueIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @string
            {
                get
                {
                    return this.stringField1;
                }
                set
                {
                    this.stringField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenuMenusActionMenuMenus
        {

            private ApplicationActionMenuMenusActionMenuMenusActionMenuMenusAction actionField;

            /// <remarks/>
            public ApplicationActionMenuMenusActionMenuMenusActionMenuMenusAction Action
            {
                get
                {
                    return this.actionField;
                }
                set
                {
                    this.actionField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenuMenusActionMenuMenusAction
        {

            private ApplicationActionMenuMenusActionMenuMenusActionMenuMenusActionMenu[] menuField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Menu")]
            public ApplicationActionMenuMenusActionMenuMenusActionMenuMenusActionMenu[] Menu
            {
                get
                {
                    return this.menuField;
                }
                set
                {
                    this.menuField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationActionMenuMenusActionMenuMenusActionMenuMenusActionMenu
        {

            private byte checkedField;

            private byte enabledField;

            private string fatherUIDField;

            private byte positionField;

            private string stringField;

            private byte typeField;

            private string uniqueIDField;

            private string stringField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Checked
            {
                get
                {
                    return this.checkedField;
                }
                set
                {
                    this.checkedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FatherUID
            {
                get
                {
                    return this.fatherUIDField;
                }
                set
                {
                    this.fatherUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string String
            {
                get
                {
                    return this.stringField;
                }
                set
                {
                    this.stringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UniqueID
            {
                get
                {
                    return this.uniqueIDField;
                }
                set
                {
                    this.uniqueIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @string
            {
                get
                {
                    return this.stringField1;
                }
                set
                {
                    this.stringField1 = value;
                }
            }
        }




    }
}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
//public partial class Application
//{

//    private ApplicationAction[] menusField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlArrayItemAttribute("Action", IsNullable = false)]
//    public ApplicationAction[] Menus
//    {
//        get
//        {
//            return this.menusField;
//        }
//        set
//        {
//            this.menusField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationAction
//{

//    private ApplicationActionMenu menuField;

//    private string typeField;

//    /// <remarks/>
//    public ApplicationActionMenu Menu
//    {
//        get
//        {
//            return this.menuField;
//        }
//        set
//        {
//            this.menuField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenu
//{

//    private ApplicationActionMenuMenus[] menusField;

//    private byte checkedField;

//    private byte enabledField;

//    private string fatherUIDField;

//    private byte positionField;

//    private string stringField;

//    private byte typeField;

//    private string uniqueIDField;

//    private string imageField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("Menus")]
//    public ApplicationActionMenuMenus[] Menus
//    {
//        get
//        {
//            return this.menusField;
//        }
//        set
//        {
//            this.menusField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Checked
//    {
//        get
//        {
//            return this.checkedField;
//        }
//        set
//        {
//            this.checkedField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Enabled
//    {
//        get
//        {
//            return this.enabledField;
//        }
//        set
//        {
//            this.enabledField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string FatherUID
//    {
//        get
//        {
//            return this.fatherUIDField;
//        }
//        set
//        {
//            this.fatherUIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Position
//    {
//        get
//        {
//            return this.positionField;
//        }
//        set
//        {
//            this.positionField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string String
//    {
//        get
//        {
//            return this.stringField;
//        }
//        set
//        {
//            this.stringField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string UniqueID
//    {
//        get
//        {
//            return this.uniqueIDField;
//        }
//        set
//        {
//            this.uniqueIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string Image
//    {
//        get
//        {
//            return this.imageField;
//        }
//        set
//        {
//            this.imageField = value;
//        }
//    }
//}

///// <summary>
///// 여기서 반복 패턴
///// </summary>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenus
//{

//    private ApplicationAction actionField;

//    /// <remarks/>
//    public ApplicationAction Action
//    {
//        get
//        {
//            return this.actionField;
//        }
//        set
//        {
//            this.actionField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusAction
//{

//    private ApplicationActionMenu[] menuField;

//    private string typeField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("Menu")]
//    public ApplicationActionMenu[] Menu
//    {
//        get
//        {
//            return this.menuField;
//        }
//        set
//        {
//            this.menuField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenu
//{

//    private ApplicationActionMenuMenus[] menusField;

//    private byte checkedField;

//    private byte enabledField;

//    private string fatherUIDField;

//    private byte positionField;

//    private string stringField;

//    private byte typeField;

//    private string uniqueIDField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("Menus")]
//    public ApplicationActionMenuMenus[] Menus
//    {
//        get
//        {
//            return this.menusField;
//        }
//        set
//        {
//            this.menusField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Checked
//    {
//        get
//        {
//            return this.checkedField;
//        }
//        set
//        {
//            this.checkedField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Enabled
//    {
//        get
//        {
//            return this.enabledField;
//        }
//        set
//        {
//            this.enabledField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string FatherUID
//    {
//        get
//        {
//            return this.fatherUIDField;
//        }
//        set
//        {
//            this.fatherUIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Position
//    {
//        get
//        {
//            return this.positionField;
//        }
//        set
//        {
//            this.positionField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string String
//    {
//        get
//        {
//            return this.stringField;
//        }
//        set
//        {
//            this.stringField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string UniqueID
//    {
//        get
//        {
//            return this.uniqueIDField;
//        }
//        set
//        {
//            this.uniqueIDField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenuMenus
//{

//    private ApplicationAction actionField;

//    /// <remarks/>
//    public ApplicationAction Action
//    {
//        get
//        {
//            return this.actionField;
//        }
//        set
//        {
//            this.actionField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenuMenusAction
//{

//    private ApplicationActionMenu[] menuField;

//    private string typeField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("Menu")]
//    public ApplicationActionMenu[] Menu
//    {
//        get
//        {
//            return this.menuField;
//        }
//        set
//        {
//            this.menuField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenuMenusActionMenu
//{

//    private ApplicationActionMenuMenus menusField;

//    private byte checkedField;

//    private byte enabledField;

//    private string fatherUIDField;

//    private byte positionField;

//    private string stringField;

//    private byte typeField;

//    private string uniqueIDField;

//    private string stringField1;

//    /// <remarks/>
//    public ApplicationActionMenuMenus Menus
//    {
//        get
//        {
//            return this.menusField;
//        }
//        set
//        {
//            this.menusField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Checked
//    {
//        get
//        {
//            return this.checkedField;
//        }
//        set
//        {
//            this.checkedField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Enabled
//    {
//        get
//        {
//            return this.enabledField;
//        }
//        set
//        {
//            this.enabledField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string FatherUID
//    {
//        get
//        {
//            return this.fatherUIDField;
//        }
//        set
//        {
//            this.fatherUIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Position
//    {
//        get
//        {
//            return this.positionField;
//        }
//        set
//        {
//            this.positionField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string String
//    {
//        get
//        {
//            return this.stringField;
//        }
//        set
//        {
//            this.stringField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string UniqueID
//    {
//        get
//        {
//            return this.uniqueIDField;
//        }
//        set
//        {
//            this.uniqueIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string @string
//    {
//        get
//        {
//            return this.stringField1;
//        }
//        set
//        {
//            this.stringField1 = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenuMenusActionMenuMenus
//{

//    private ApplicationAction actionField;

//    /// <remarks/>
//    public ApplicationAction Action
//    {
//        get
//        {
//            return this.actionField;
//        }
//        set
//        {
//            this.actionField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenuMenusActionMenuMenusAction
//{

//    private ApplicationActionMenu[] menuField;

//    private string typeField;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlElementAttribute("Menu")]
//    public ApplicationActionMenu[] Menu
//    {
//        get
//        {
//            return this.menuField;
//        }
//        set
//        {
//            this.menuField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }
//}

///// <remarks/>
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
//public partial class ApplicationActionMenuMenusActionMenuMenusActionMenuMenusActionMenu
//{

//    private byte checkedField;

//    private byte enabledField;

//    private string fatherUIDField;

//    private byte positionField;

//    private string stringField;

//    private byte typeField;

//    private string uniqueIDField;

//    private string stringField1;

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Checked
//    {
//        get
//        {
//            return this.checkedField;
//        }
//        set
//        {
//            this.checkedField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Enabled
//    {
//        get
//        {
//            return this.enabledField;
//        }
//        set
//        {
//            this.enabledField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string FatherUID
//    {
//        get
//        {
//            return this.fatherUIDField;
//        }
//        set
//        {
//            this.fatherUIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Position
//    {
//        get
//        {
//            return this.positionField;
//        }
//        set
//        {
//            this.positionField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string String
//    {
//        get
//        {
//            return this.stringField;
//        }
//        set
//        {
//            this.stringField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public byte Type
//    {
//        get
//        {
//            return this.typeField;
//        }
//        set
//        {
//            this.typeField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string UniqueID
//    {
//        get
//        {
//            return this.uniqueIDField;
//        }
//        set
//        {
//            this.uniqueIDField = value;
//        }
//    }

//    /// <remarks/>
//    [System.Xml.Serialization.XmlAttributeAttribute()]
//    public string @string
//    {
//        get
//        {
//            return this.stringField1;
//        }
//        set
//        {
//            this.stringField1 = value;
//        }
//    }
//}

