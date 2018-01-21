using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARPATest
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class data
    {

        private string languageField;

        private string creditField;

        private string credit_urlField;

        private string credit_mailField;

        private string suggested_pickupField;

        private byte suggested_pickup_periodField;

        private string last_updateField;

        private dataMeteo_data meteo_dataField;

        private dataMeteo_data_daily meteo_data_dailyField;

        private string idField;

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public string credit_url
        {
            get
            {
                return this.credit_urlField;
            }
            set
            {
                this.credit_urlField = value;
            }
        }

        /// <remarks/>
        public string credit_mail
        {
            get
            {
                return this.credit_mailField;
            }
            set
            {
                this.credit_mailField = value;
            }
        }

        /// <remarks/>
        public string suggested_pickup
        {
            get
            {
                return this.suggested_pickupField;
            }
            set
            {
                this.suggested_pickupField = value;
            }
        }

        /// <remarks/>
        public byte suggested_pickup_period
        {
            get
            {
                return this.suggested_pickup_periodField;
            }
            set
            {
                this.suggested_pickup_periodField = value;
            }
        }

        /// <remarks/>
        public string last_update
        {
            get
            {
                return this.last_updateField;
            }
            set
            {
                this.last_updateField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data meteo_data
        {
            get
            {
                return this.meteo_dataField;
            }
            set
            {
                this.meteo_dataField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_daily meteo_data_daily
        {
            get
            {
                return this.meteo_data_dailyField;
            }
            set
            {
                this.meteo_data_dailyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data
    {

        private string observation_timeField;

        private string observation_dateField;

        private string observation_hourField;

        private string station_idField;

        private string station_nameField;

        private dataMeteo_dataRR rrField;

        private byte prec_typeField;

        private dataMeteo_dataT180 t180Field;

        private dataMeteo_dataRG rgField;

        private byte cloudinessField;

        private dataMeteo_dataRH rhField;

        private dataMeteo_dataPress pressField;

        /// <remarks/>
        public string observation_time
        {
            get
            {
                return this.observation_timeField;
            }
            set
            {
                this.observation_timeField = value;
            }
        }

        /// <remarks/>
        public string observation_date
        {
            get
            {
                return this.observation_dateField;
            }
            set
            {
                this.observation_dateField = value;
            }
        }

        /// <remarks/>
        public string observation_hour
        {
            get
            {
                return this.observation_hourField;
            }
            set
            {
                this.observation_hourField = value;
            }
        }

        /// <remarks/>
        public string station_id
        {
            get
            {
                return this.station_idField;
            }
            set
            {
                this.station_idField = value;
            }
        }

        /// <remarks/>
        public string station_name
        {
            get
            {
                return this.station_nameField;
            }
            set
            {
                this.station_nameField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_dataRR rr
        {
            get
            {
                return this.rrField;
            }
            set
            {
                this.rrField = value;
            }
        }

        /// <remarks/>
        public byte prec_type
        {
            get
            {
                return this.prec_typeField;
            }
            set
            {
                this.prec_typeField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_dataT180 t180
        {
            get
            {
                return this.t180Field;
            }
            set
            {
                this.t180Field = value;
            }
        }

        /// <remarks/>
        public dataMeteo_dataRG rg
        {
            get
            {
                return this.rgField;
            }
            set
            {
                this.rgField = value;
            }
        }

        /// <remarks/>
        public byte cloudiness
        {
            get
            {
                return this.cloudinessField;
            }
            set
            {
                this.cloudinessField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_dataRH rh
        {
            get
            {
                return this.rhField;
            }
            set
            {
                this.rhField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_dataPress press
        {
            get
            {
                return this.pressField;
            }
            set
            {
                this.pressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_dataRR
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_dataT180
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_dataRG
    {

        private string descriptionField;

        private string umField;

        private byte valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_dataRH
    {

        private string descriptionField;

        private string umField;

        private byte valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_dataPress
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_daily
    {

        private string summary_timeField;

        private string summary_dateField;

        private string summary_hourField;

        private string station_idField;

        private string station_nameField;

        private dataMeteo_data_dailyRr_cum rr_cumField;

        private dataMeteo_data_dailyT180_min t180_minField;

        private dataMeteo_data_dailyT180_med t180_medField;

        private dataMeteo_data_dailyT180_max t180_maxField;

        private dataMeteo_data_dailyRg_cum rg_cumField;

        private byte cloudinessField;

        private dataMeteo_data_dailyRh_med rh_medField;

        private dataMeteo_data_dailyPress_min press_minField;

        private dataMeteo_data_dailyPress_max press_maxField;

        /// <remarks/>
        public string summary_time
        {
            get
            {
                return this.summary_timeField;
            }
            set
            {
                this.summary_timeField = value;
            }
        }

        /// <remarks/>
        public string summary_date
        {
            get
            {
                return this.summary_dateField;
            }
            set
            {
                this.summary_dateField = value;
            }
        }

        /// <remarks/>
        public string summary_hour
        {
            get
            {
                return this.summary_hourField;
            }
            set
            {
                this.summary_hourField = value;
            }
        }

        /// <remarks/>
        public string station_id
        {
            get
            {
                return this.station_idField;
            }
            set
            {
                this.station_idField = value;
            }
        }

        /// <remarks/>
        public string station_name
        {
            get
            {
                return this.station_nameField;
            }
            set
            {
                this.station_nameField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyRr_cum rr_cum
        {
            get
            {
                return this.rr_cumField;
            }
            set
            {
                this.rr_cumField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyT180_min t180_min
        {
            get
            {
                return this.t180_minField;
            }
            set
            {
                this.t180_minField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyT180_med t180_med
        {
            get
            {
                return this.t180_medField;
            }
            set
            {
                this.t180_medField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyT180_max t180_max
        {
            get
            {
                return this.t180_maxField;
            }
            set
            {
                this.t180_maxField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyRg_cum rg_cum
        {
            get
            {
                return this.rg_cumField;
            }
            set
            {
                this.rg_cumField = value;
            }
        }

        /// <remarks/>
        public byte cloudiness
        {
            get
            {
                return this.cloudinessField;
            }
            set
            {
                this.cloudinessField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyRh_med rh_med
        {
            get
            {
                return this.rh_medField;
            }
            set
            {
                this.rh_medField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyPress_min press_min
        {
            get
            {
                return this.press_minField;
            }
            set
            {
                this.press_minField = value;
            }
        }

        /// <remarks/>
        public dataMeteo_data_dailyPress_max press_max
        {
            get
            {
                return this.press_maxField;
            }
            set
            {
                this.press_maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyRr_cum
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyT180_min
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyT180_med
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyT180_max
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyRg_cum
    {

        private string descriptionField;

        private string umField;

        private byte valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyRh_med
    {

        private string descriptionField;

        private string umField;

        private byte valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyPress_min
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMeteo_data_dailyPress_max
    {

        private string descriptionField;

        private string umField;

        private decimal valueField;

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
        public string um
        {
            get
            {
                return this.umField;
            }
            set
            {
                this.umField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    }


}
