using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationXmlDeserialize
{
    public class FormCollection
    { 
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Application
        {

            private ApplicationForms formsField;

            /// <remarks/>
            public ApplicationForms forms
            {
                get
                {
                    return this.formsField;
                }
                set
                {
                    this.formsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationForms
        {

            private ApplicationFormsAction actionField;

            /// <remarks/>
            public ApplicationFormsAction action
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
        public partial class ApplicationFormsAction
        {

            private ApplicationFormsActionForm formField;

            private string typeField;

            /// <remarks/>
            public ApplicationFormsActionForm form
            {
                get
                {
                    return this.formField;
                }
                set
                {
                    this.formField = value;
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
        public partial class ApplicationFormsActionForm
        {

            private object[] itemsField;

            private string appformnumberField;

            private string formTypeField;

            private byte typeField;

            private byte borderStyleField;

            private string uidField;

            private string titleField;

            private byte visibleField;

            private byte default_buttonField;

            private byte paneField;

            private byte colorField;

            private byte leftField;

            private byte topField;

            private ushort widthField;

            private ushort heightField;

            private ushort client_widthField;

            private byte client_heightField;

            private byte autoManagedField;

            private byte supportedModesField;

            private string objectTypeField;

            private byte modeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ChooseFromListCollection", typeof(ApplicationFormsActionFormChooseFromListCollection))]
            [System.Xml.Serialization.XmlElementAttribute("DataBrowser", typeof(ApplicationFormsActionFormDataBrowser))]
            [System.Xml.Serialization.XmlElementAttribute("Menus", typeof(object))]
            [System.Xml.Serialization.XmlElementAttribute("Settings", typeof(ApplicationFormsActionFormSettings))]
            [System.Xml.Serialization.XmlElementAttribute("datasources", typeof(ApplicationFormsActionFormDatasources))]
            [System.Xml.Serialization.XmlElementAttribute("items", typeof(ApplicationFormsActionFormItems))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string appformnumber
            {
                get
                {
                    return this.appformnumberField;
                }
                set
                {
                    this.appformnumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FormType
            {
                get
                {
                    return this.formTypeField;
                }
                set
                {
                    this.formTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte type
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
            public byte BorderStyle
            {
                get
                {
                    return this.borderStyleField;
                }
                set
                {
                    this.borderStyleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uid
            {
                get
                {
                    return this.uidField;
                }
                set
                {
                    this.uidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte visible
            {
                get
                {
                    return this.visibleField;
                }
                set
                {
                    this.visibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte default_button
            {
                get
                {
                    return this.default_buttonField;
                }
                set
                {
                    this.default_buttonField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte pane
            {
                get
                {
                    return this.paneField;
                }
                set
                {
                    this.paneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte color
            {
                get
                {
                    return this.colorField;
                }
                set
                {
                    this.colorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte left
            {
                get
                {
                    return this.leftField;
                }
                set
                {
                    this.leftField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte top
            {
                get
                {
                    return this.topField;
                }
                set
                {
                    this.topField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort client_width
            {
                get
                {
                    return this.client_widthField;
                }
                set
                {
                    this.client_widthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte client_height
            {
                get
                {
                    return this.client_heightField;
                }
                set
                {
                    this.client_heightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AutoManaged
            {
                get
                {
                    return this.autoManagedField;
                }
                set
                {
                    this.autoManagedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte SupportedModes
            {
                get
                {
                    return this.supportedModesField;
                }
                set
                {
                    this.supportedModesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ObjectType
            {
                get
                {
                    return this.objectTypeField;
                }
                set
                {
                    this.objectTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte mode
            {
                get
                {
                    return this.modeField;
                }
                set
                {
                    this.modeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormChooseFromListCollection
        {

            private ApplicationFormsActionFormChooseFromListCollectionAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormChooseFromListCollectionAction action
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
        public partial class ApplicationFormsActionFormChooseFromListCollectionAction
        {

            private ApplicationFormsActionFormChooseFromListCollectionActionChooseFromList chooseFromListField;

            private string typeField;

            /// <remarks/>
            public ApplicationFormsActionFormChooseFromListCollectionActionChooseFromList ChooseFromList
            {
                get
                {
                    return this.chooseFromListField;
                }
                set
                {
                    this.chooseFromListField = value;
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
        public partial class ApplicationFormsActionFormChooseFromListCollectionActionChooseFromList
        {

            private sbyte uniqueIDField;

            private sbyte objectTypeField;

            private byte multiSelectionField;

            private byte isSystemField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte UniqueID
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
            public sbyte ObjectType
            {
                get
                {
                    return this.objectTypeField;
                }
                set
                {
                    this.objectTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte MultiSelection
            {
                get
                {
                    return this.multiSelectionField;
                }
                set
                {
                    this.multiSelectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsSystem
            {
                get
                {
                    return this.isSystemField;
                }
                set
                {
                    this.isSystemField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormDataBrowser
        {

            private string browseByField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BrowseBy
            {
                get
                {
                    return this.browseByField;
                }
                set
                {
                    this.browseByField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormSettings
        {

            private string matrixUIDField;

            private byte enabledField;

            private byte enableRowFormatField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string MatrixUID
            {
                get
                {
                    return this.matrixUIDField;
                }
                set
                {
                    this.matrixUIDField = value;
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
            public byte EnableRowFormat
            {
                get
                {
                    return this.enableRowFormatField;
                }
                set
                {
                    this.enableRowFormatField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormDatasources
        {

            private object dataTablesField;

            private ApplicationFormsActionFormDatasourcesDbdatasources dbdatasourcesField;

            private ApplicationFormsActionFormDatasourcesUserdatasources userdatasourcesField;

            /// <remarks/>
            public object DataTables
            {
                get
                {
                    return this.dataTablesField;
                }
                set
                {
                    this.dataTablesField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormDatasourcesDbdatasources dbdatasources
            {
                get
                {
                    return this.dbdatasourcesField;
                }
                set
                {
                    this.dbdatasourcesField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormDatasourcesUserdatasources userdatasources
            {
                get
                {
                    return this.userdatasourcesField;
                }
                set
                {
                    this.userdatasourcesField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormDatasourcesDbdatasources
        {

            private ApplicationFormsActionFormDatasourcesDbdatasourcesAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormDatasourcesDbdatasourcesAction action
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
        public partial class ApplicationFormsActionFormDatasourcesDbdatasourcesAction
        {

            private ApplicationFormsActionFormDatasourcesDbdatasourcesActionDatasource[] datasourceField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("datasource")]
            public ApplicationFormsActionFormDatasourcesDbdatasourcesActionDatasource[] datasource
            {
                get
                {
                    return this.datasourceField;
                }
                set
                {
                    this.datasourceField = value;
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
        public partial class ApplicationFormsActionFormDatasourcesDbdatasourcesActionDatasource
        {

            private string tablenameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string tablename
            {
                get
                {
                    return this.tablenameField;
                }
                set
                {
                    this.tablenameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormDatasourcesUserdatasources
        {

            private ApplicationFormsActionFormDatasourcesUserdatasourcesAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormDatasourcesUserdatasourcesAction action
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
        public partial class ApplicationFormsActionFormDatasourcesUserdatasourcesAction
        {

            private ApplicationFormsActionFormDatasourcesUserdatasourcesActionDatasource datasourceField;

            private string typeField;

            /// <remarks/>
            public ApplicationFormsActionFormDatasourcesUserdatasourcesActionDatasource datasource
            {
                get
                {
                    return this.datasourceField;
                }
                set
                {
                    this.datasourceField = value;
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
        public partial class ApplicationFormsActionFormDatasourcesUserdatasourcesActionDatasource
        {

            private string uidField;

            private byte typeField;

            private byte sizeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uid
            {
                get
                {
                    return this.uidField;
                }
                set
                {
                    this.uidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte type
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
            public byte size
            {
                get
                {
                    return this.sizeField;
                }
                set
                {
                    this.sizeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItems
        {

            private ApplicationFormsActionFormItemsAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormItemsAction action
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
        public partial class ApplicationFormsActionFormItemsAction
        {

            private ApplicationFormsActionFormItemsActionItem[] itemField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("item")]
            public ApplicationFormsActionFormItemsActionItem[] item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
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
        public partial class ApplicationFormsActionFormItemsActionItem
        {

            private object autoManagedAttributeField;

            private ApplicationFormsActionFormItemsActionItemSpecific specificField;

            private string uidField;

            private byte typeField;

            private bool typeFieldSpecified;

            private short leftField;

            private bool leftFieldSpecified;

            private byte tab_orderField;

            private bool tab_orderFieldSpecified;

            private ushort widthField;

            private bool widthFieldSpecified;

            private ushort topField;

            private bool topFieldSpecified;

            private ushort heightField;

            private bool heightFieldSpecified;

            private byte visibleField;

            private bool visibleFieldSpecified;

            private byte enabledField;

            private bool enabledFieldSpecified;

            private byte from_paneField;

            private bool from_paneFieldSpecified;

            private byte to_paneField;

            private bool to_paneFieldSpecified;

            private byte disp_descField;

            private bool disp_descFieldSpecified;

            private byte right_justField;

            private bool right_justFieldSpecified;

            private string descriptionField;

            private string linktoField;

            private sbyte forecolorField;

            private bool forecolorFieldSpecified;

            private sbyte backcolorField;

            private bool backcolorFieldSpecified;

            private string text_styleField;

            private sbyte font_sizeField;

            private bool font_sizeFieldSpecified;

            private byte supp_zerosField;

            private bool supp_zerosFieldSpecified;

            private byte affectsFormModeField;

            private bool affectsFormModeFieldSpecified;

            private byte isAutoGeneratedField;

            private bool isAutoGeneratedFieldSpecified;

            private byte cellHeightField;

            private bool cellHeightFieldSpecified;

            private byte titleHeightField;

            private bool titleHeightFieldSpecified;

            /// <remarks/>
            public object AutoManagedAttribute
            {
                get
                {
                    return this.autoManagedAttributeField;
                }
                set
                {
                    this.autoManagedAttributeField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecific specific
            {
                get
                {
                    return this.specificField;
                }
                set
                {
                    this.specificField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uid
            {
                get
                {
                    return this.uidField;
                }
                set
                {
                    this.uidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte type
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
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool typeSpecified
            {
                get
                {
                    return this.typeFieldSpecified;
                }
                set
                {
                    this.typeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public short left
            {
                get
                {
                    return this.leftField;
                }
                set
                {
                    this.leftField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool leftSpecified
            {
                get
                {
                    return this.leftFieldSpecified;
                }
                set
                {
                    this.leftFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte tab_order
            {
                get
                {
                    return this.tab_orderField;
                }
                set
                {
                    this.tab_orderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool tab_orderSpecified
            {
                get
                {
                    return this.tab_orderFieldSpecified;
                }
                set
                {
                    this.tab_orderFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool widthSpecified
            {
                get
                {
                    return this.widthFieldSpecified;
                }
                set
                {
                    this.widthFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort top
            {
                get
                {
                    return this.topField;
                }
                set
                {
                    this.topField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool topSpecified
            {
                get
                {
                    return this.topFieldSpecified;
                }
                set
                {
                    this.topFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool heightSpecified
            {
                get
                {
                    return this.heightFieldSpecified;
                }
                set
                {
                    this.heightFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte visible
            {
                get
                {
                    return this.visibleField;
                }
                set
                {
                    this.visibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool visibleSpecified
            {
                get
                {
                    return this.visibleFieldSpecified;
                }
                set
                {
                    this.visibleFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte enabled
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
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool enabledSpecified
            {
                get
                {
                    return this.enabledFieldSpecified;
                }
                set
                {
                    this.enabledFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte from_pane
            {
                get
                {
                    return this.from_paneField;
                }
                set
                {
                    this.from_paneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool from_paneSpecified
            {
                get
                {
                    return this.from_paneFieldSpecified;
                }
                set
                {
                    this.from_paneFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte to_pane
            {
                get
                {
                    return this.to_paneField;
                }
                set
                {
                    this.to_paneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool to_paneSpecified
            {
                get
                {
                    return this.to_paneFieldSpecified;
                }
                set
                {
                    this.to_paneFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte disp_desc
            {
                get
                {
                    return this.disp_descField;
                }
                set
                {
                    this.disp_descField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool disp_descSpecified
            {
                get
                {
                    return this.disp_descFieldSpecified;
                }
                set
                {
                    this.disp_descFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte right_just
            {
                get
                {
                    return this.right_justField;
                }
                set
                {
                    this.right_justField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool right_justSpecified
            {
                get
                {
                    return this.right_justFieldSpecified;
                }
                set
                {
                    this.right_justFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string linkto
            {
                get
                {
                    return this.linktoField;
                }
                set
                {
                    this.linktoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte forecolor
            {
                get
                {
                    return this.forecolorField;
                }
                set
                {
                    this.forecolorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool forecolorSpecified
            {
                get
                {
                    return this.forecolorFieldSpecified;
                }
                set
                {
                    this.forecolorFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte backcolor
            {
                get
                {
                    return this.backcolorField;
                }
                set
                {
                    this.backcolorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool backcolorSpecified
            {
                get
                {
                    return this.backcolorFieldSpecified;
                }
                set
                {
                    this.backcolorFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string text_style
            {
                get
                {
                    return this.text_styleField;
                }
                set
                {
                    this.text_styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte font_size
            {
                get
                {
                    return this.font_sizeField;
                }
                set
                {
                    this.font_sizeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool font_sizeSpecified
            {
                get
                {
                    return this.font_sizeFieldSpecified;
                }
                set
                {
                    this.font_sizeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte supp_zeros
            {
                get
                {
                    return this.supp_zerosField;
                }
                set
                {
                    this.supp_zerosField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool supp_zerosSpecified
            {
                get
                {
                    return this.supp_zerosFieldSpecified;
                }
                set
                {
                    this.supp_zerosFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AffectsFormMode
            {
                get
                {
                    return this.affectsFormModeField;
                }
                set
                {
                    this.affectsFormModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AffectsFormModeSpecified
            {
                get
                {
                    return this.affectsFormModeFieldSpecified;
                }
                set
                {
                    this.affectsFormModeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsAutoGenerated
            {
                get
                {
                    return this.isAutoGeneratedField;
                }
                set
                {
                    this.isAutoGeneratedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IsAutoGeneratedSpecified
            {
                get
                {
                    return this.isAutoGeneratedFieldSpecified;
                }
                set
                {
                    this.isAutoGeneratedFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte cellHeight
            {
                get
                {
                    return this.cellHeightField;
                }
                set
                {
                    this.cellHeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool cellHeightSpecified
            {
                get
                {
                    return this.cellHeightFieldSpecified;
                }
                set
                {
                    this.cellHeightFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte titleHeight
            {
                get
                {
                    return this.titleHeightField;
                }
                set
                {
                    this.titleHeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool titleHeightSpecified
            {
                get
                {
                    return this.titleHeightFieldSpecified;
                }
                set
                {
                    this.titleHeightFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItemsActionItemSpecific
        {

            private ApplicationFormsActionFormItemsActionItemSpecificColumns columnsField;

            private ApplicationFormsActionFormItemsActionItemSpecificValidValues validValuesField;

            private ApplicationFormsActionFormItemsActionItemSpecificDatabind databindField;

            private byte paneField;

            private bool paneFieldSpecified;

            private string captionField;

            private byte autoPaneSelectionField;

            private bool autoPaneSelectionFieldSpecified;

            private string chooseFromListAliasField;

            private byte chooseFromListIsAutoFillField;

            private bool chooseFromListIsAutoFillFieldSpecified;

            private string chooseFromListUIDField;

            private byte isPasswordField;

            private bool isPasswordFieldSpecified;

            private byte supp_zerosField;

            private bool supp_zerosFieldSpecified;

            private string val_onField;

            private string val_offField;

            private byte layoutField;

            private bool layoutFieldSpecified;

            private byte selectionModeField;

            private bool selectionModeFieldSpecified;

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificColumns columns
            {
                get
                {
                    return this.columnsField;
                }
                set
                {
                    this.columnsField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificValidValues ValidValues
            {
                get
                {
                    return this.validValuesField;
                }
                set
                {
                    this.validValuesField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificDatabind databind
            {
                get
                {
                    return this.databindField;
                }
                set
                {
                    this.databindField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte pane
            {
                get
                {
                    return this.paneField;
                }
                set
                {
                    this.paneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool paneSpecified
            {
                get
                {
                    return this.paneFieldSpecified;
                }
                set
                {
                    this.paneFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string caption
            {
                get
                {
                    return this.captionField;
                }
                set
                {
                    this.captionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AutoPaneSelection
            {
                get
                {
                    return this.autoPaneSelectionField;
                }
                set
                {
                    this.autoPaneSelectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AutoPaneSelectionSpecified
            {
                get
                {
                    return this.autoPaneSelectionFieldSpecified;
                }
                set
                {
                    this.autoPaneSelectionFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ChooseFromListAlias
            {
                get
                {
                    return this.chooseFromListAliasField;
                }
                set
                {
                    this.chooseFromListAliasField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ChooseFromListIsAutoFill
            {
                get
                {
                    return this.chooseFromListIsAutoFillField;
                }
                set
                {
                    this.chooseFromListIsAutoFillField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ChooseFromListIsAutoFillSpecified
            {
                get
                {
                    return this.chooseFromListIsAutoFillFieldSpecified;
                }
                set
                {
                    this.chooseFromListIsAutoFillFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ChooseFromListUID
            {
                get
                {
                    return this.chooseFromListUIDField;
                }
                set
                {
                    this.chooseFromListUIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsPassword
            {
                get
                {
                    return this.isPasswordField;
                }
                set
                {
                    this.isPasswordField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IsPasswordSpecified
            {
                get
                {
                    return this.isPasswordFieldSpecified;
                }
                set
                {
                    this.isPasswordFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte supp_zeros
            {
                get
                {
                    return this.supp_zerosField;
                }
                set
                {
                    this.supp_zerosField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool supp_zerosSpecified
            {
                get
                {
                    return this.supp_zerosFieldSpecified;
                }
                set
                {
                    this.supp_zerosFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string val_on
            {
                get
                {
                    return this.val_onField;
                }
                set
                {
                    this.val_onField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string val_off
            {
                get
                {
                    return this.val_offField;
                }
                set
                {
                    this.val_offField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte layout
            {
                get
                {
                    return this.layoutField;
                }
                set
                {
                    this.layoutField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool layoutSpecified
            {
                get
                {
                    return this.layoutFieldSpecified;
                }
                set
                {
                    this.layoutFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte SelectionMode
            {
                get
                {
                    return this.selectionModeField;
                }
                set
                {
                    this.selectionModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool SelectionModeSpecified
            {
                get
                {
                    return this.selectionModeFieldSpecified;
                }
                set
                {
                    this.selectionModeFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumns
        {

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsAction action
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
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsAction
        {

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumn[] columnField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("column")]
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumn[] column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
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
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumn
        {

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnDatabind databindField;

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnExtendedObject extendedObjectField;

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValues validValuesField;

            private int backcolorField;

            private bool backcolorFieldSpecified;

            private byte chooseFromListIsAutoFillField;

            private bool chooseFromListIsAutoFillFieldSpecified;

            private sbyte font_sizeField;

            private bool font_sizeFieldSpecified;

            private sbyte forecolorField;

            private bool forecolorFieldSpecified;

            private byte text_styleField;

            private bool text_styleFieldSpecified;

            private byte disp_descField;

            private byte visibleField;

            private byte affectsFormModeField;

            private string val_onField;

            private byte isAutoGeneratedField;

            private string val_offField;

            private string titleField;

            private byte widthField;

            private byte editableField;

            private byte typeField;

            private byte right_justField;

            private string uidField;

            private byte sortableField;

            private string chooseFromListAliasField;

            private string chooseFromListUIDField;

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnDatabind databind
            {
                get
                {
                    return this.databindField;
                }
                set
                {
                    this.databindField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnExtendedObject ExtendedObject
            {
                get
                {
                    return this.extendedObjectField;
                }
                set
                {
                    this.extendedObjectField = value;
                }
            }

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValues ValidValues
            {
                get
                {
                    return this.validValuesField;
                }
                set
                {
                    this.validValuesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int backcolor
            {
                get
                {
                    return this.backcolorField;
                }
                set
                {
                    this.backcolorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool backcolorSpecified
            {
                get
                {
                    return this.backcolorFieldSpecified;
                }
                set
                {
                    this.backcolorFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ChooseFromListIsAutoFill
            {
                get
                {
                    return this.chooseFromListIsAutoFillField;
                }
                set
                {
                    this.chooseFromListIsAutoFillField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ChooseFromListIsAutoFillSpecified
            {
                get
                {
                    return this.chooseFromListIsAutoFillFieldSpecified;
                }
                set
                {
                    this.chooseFromListIsAutoFillFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte font_size
            {
                get
                {
                    return this.font_sizeField;
                }
                set
                {
                    this.font_sizeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool font_sizeSpecified
            {
                get
                {
                    return this.font_sizeFieldSpecified;
                }
                set
                {
                    this.font_sizeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte forecolor
            {
                get
                {
                    return this.forecolorField;
                }
                set
                {
                    this.forecolorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool forecolorSpecified
            {
                get
                {
                    return this.forecolorFieldSpecified;
                }
                set
                {
                    this.forecolorFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte text_style
            {
                get
                {
                    return this.text_styleField;
                }
                set
                {
                    this.text_styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool text_styleSpecified
            {
                get
                {
                    return this.text_styleFieldSpecified;
                }
                set
                {
                    this.text_styleFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte disp_desc
            {
                get
                {
                    return this.disp_descField;
                }
                set
                {
                    this.disp_descField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte visible
            {
                get
                {
                    return this.visibleField;
                }
                set
                {
                    this.visibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte AffectsFormMode
            {
                get
                {
                    return this.affectsFormModeField;
                }
                set
                {
                    this.affectsFormModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string val_on
            {
                get
                {
                    return this.val_onField;
                }
                set
                {
                    this.val_onField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte IsAutoGenerated
            {
                get
                {
                    return this.isAutoGeneratedField;
                }
                set
                {
                    this.isAutoGeneratedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string val_off
            {
                get
                {
                    return this.val_offField;
                }
                set
                {
                    this.val_offField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte editable
            {
                get
                {
                    return this.editableField;
                }
                set
                {
                    this.editableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte type
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
            public byte right_just
            {
                get
                {
                    return this.right_justField;
                }
                set
                {
                    this.right_justField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uid
            {
                get
                {
                    return this.uidField;
                }
                set
                {
                    this.uidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sortable
            {
                get
                {
                    return this.sortableField;
                }
                set
                {
                    this.sortableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ChooseFromListAlias
            {
                get
                {
                    return this.chooseFromListAliasField;
                }
                set
                {
                    this.chooseFromListAliasField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ChooseFromListUID
            {
                get
                {
                    return this.chooseFromListUIDField;
                }
                set
                {
                    this.chooseFromListUIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnDatabind
        {

            private byte databoundField;

            private string tableField;

            private string aliasField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte databound
            {
                get
                {
                    return this.databoundField;
                }
                set
                {
                    this.databoundField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string table
            {
                get
                {
                    return this.tableField;
                }
                set
                {
                    this.tableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string alias
            {
                get
                {
                    return this.aliasField;
                }
                set
                {
                    this.aliasField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnExtendedObject
        {

            private byte linkedObjectField;

            private byte linkedObjectTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte linkedObject
            {
                get
                {
                    return this.linkedObjectField;
                }
                set
                {
                    this.linkedObjectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte LinkedObjectType
            {
                get
                {
                    return this.linkedObjectTypeField;
                }
                set
                {
                    this.linkedObjectTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValues
        {

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValuesAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValuesAction action
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
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValuesAction
        {

            private ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValuesActionValidValue[] validValueField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ValidValue")]
            public ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValuesActionValidValue[] ValidValue
            {
                get
                {
                    return this.validValueField;
                }
                set
                {
                    this.validValueField = value;
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
        public partial class ApplicationFormsActionFormItemsActionItemSpecificColumnsActionColumnValidValuesActionValidValue
        {

            private string valueField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ApplicationFormsActionFormItemsActionItemSpecificValidValues
        {

            private ApplicationFormsActionFormItemsActionItemSpecificValidValuesAction actionField;

            /// <remarks/>
            public ApplicationFormsActionFormItemsActionItemSpecificValidValuesAction action
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
        public partial class ApplicationFormsActionFormItemsActionItemSpecificValidValuesAction
        {

            private string typeField;

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
        public partial class ApplicationFormsActionFormItemsActionItemSpecificDatabind
        {

            private byte databoundField;

            private string tableField;

            private string aliasField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte databound
            {
                get
                {
                    return this.databoundField;
                }
                set
                {
                    this.databoundField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string table
            {
                get
                {
                    return this.tableField;
                }
                set
                {
                    this.tableField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string alias
            {
                get
                {
                    return this.aliasField;
                }
                set
                {
                    this.aliasField = value;
                }
            }
        }

    }
}
