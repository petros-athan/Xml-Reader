using System;

namespace XML_Reader_p
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement", IsNullable = false)]
    public partial class SubaAcknowledgement
    {

        private string referredSenderIdField;

        private ushort referredIREFField;

        private System.DateTime referredDateTimeReceivedField;

        private string fileNameField;

        private SubaAcknowledgementReportContext reportContextField;

        private string acceptanceStatusField;

        private string validationStatusField;

        private string nCAreactionField;

        private byte versionField;

        private byte revisionField;

        private SubaAcknowledgementStatistics statisticsField;

        private SubaAcknowledgementError[] errorsFoundField;

        /// <remarks/>
        public string ReferredSenderId
        {
            get
            {
                return this.referredSenderIdField;
            }
            set
            {
                this.referredSenderIdField = value;
            }
        }

        /// <remarks/>
        public string NCAreaction
        {
            get
            {
                return this.nCAreactionField;
            }
            set
            {
                this.nCAreactionField = value;
            }
        }

        /// <remarks/>
        public ushort ReferredIREF
        {
            get
            {
                return this.referredIREFField;
            }
            set
            {
                this.referredIREFField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ReferredDateTimeReceived
        {
            get
            {
                return this.referredDateTimeReceivedField;
            }
            set
            {
                this.referredDateTimeReceivedField = value;
            }
        }

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public SubaAcknowledgementReportContext ReportContext
        {
            get
            {
                return this.reportContextField;
            }
            set
            {
                this.reportContextField = value;
            }
        }

        /// <remarks/>
        public string AcceptanceStatus
        {
            get
            {
                return this.acceptanceStatusField;
            }
            set
            {
                this.acceptanceStatusField = value;
            }
        }

        /// <remarks/>
        public string ValidationStatus
        {
            get
            {
                return this.validationStatusField;
            }
            set
            {
                this.validationStatusField = value;
            }
        }

        /// <remarks/>
        public byte Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public byte Revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        public SubaAcknowledgementStatistics Statistics
        {
            get
            {
                return this.statisticsField;
            }
            set
            {
                this.statisticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Error", IsNullable = false)]
        public SubaAcknowledgementError[] ErrorsFound
        {
            get
            {
                return this.errorsFoundField;
            }
            set
            {
                this.errorsFoundField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementReportContext
    {

        private SubaAcknowledgementReportContextReportedEntity reportedEntityField;

        private string moduleField;

        private System.DateTime referenceDateField;

        /// <remarks/>
        public SubaAcknowledgementReportContextReportedEntity ReportedEntity
        {
            get
            {
                return this.reportedEntityField;
            }
            set
            {
                this.reportedEntityField = value;
            }
        }

        /// <remarks/>
        public string Module
        {
            get
            {
                return this.moduleField;
            }
            set
            {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ReferenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementReportContextReportedEntity
    {

        private SubaAcknowledgementReportContextReportedEntityEntityId entityIdField;

        private string entityNameField;

        /// <remarks/>
        public SubaAcknowledgementReportContextReportedEntityEntityId EntityId
        {
            get
            {
                return this.entityIdField;
            }
            set
            {
                this.entityIdField = value;
            }
        }

        /// <remarks/>
        public string EntityName
        {
            get
            {
                return this.entityNameField;
            }
            set
            {
                this.entityNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementReportContextReportedEntityEntityId
    {

        private string schemeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scheme
        {
            get
            {
                return this.schemeField;
            }
            set
            {
                this.schemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementStatistics
    {

        private ushort numberOfValidItemsField;

        private byte numberOfInformationItemsField;

        private byte numberOfWarningsField;

        private byte numberOfNonRestrictiveErrorsField;

        private byte numberOfErrorsField;

        private byte numberOfFatalErrorsField;

        private byte filingIndicatorsFoundField;

        private byte numberOfContextFoundField;

        private ushort numberOfFactsFoundField;

        /// <remarks/>
        public ushort NumberOfValidItems
        {
            get
            {
                return this.numberOfValidItemsField;
            }
            set
            {
                this.numberOfValidItemsField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfInformationItems
        {
            get
            {
                return this.numberOfInformationItemsField;
            }
            set
            {
                this.numberOfInformationItemsField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfWarnings
        {
            get
            {
                return this.numberOfWarningsField;
            }
            set
            {
                this.numberOfWarningsField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfNonRestrictiveErrors
        {
            get
            {
                return this.numberOfNonRestrictiveErrorsField;
            }
            set
            {
                this.numberOfNonRestrictiveErrorsField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfErrors
        {
            get
            {
                return this.numberOfErrorsField;
            }
            set
            {
                this.numberOfErrorsField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfFatalErrors
        {
            get
            {
                return this.numberOfFatalErrorsField;
            }
            set
            {
                this.numberOfFatalErrorsField = value;
            }
        }

        /// <remarks/>
        public byte FilingIndicatorsFound
        {
            get
            {
                return this.filingIndicatorsFoundField;
            }
            set
            {
                this.filingIndicatorsFoundField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfContextFound
        {
            get
            {
                return this.numberOfContextFoundField;
            }
            set
            {
                this.numberOfContextFoundField = value;
            }
        }

        /// <remarks/>
        public ushort NumberOfFactsFound
        {
            get
            {
                return this.numberOfFactsFoundField;
            }
            set
            {
                this.numberOfFactsFoundField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementError
    {

        private string errorCodeField;

        private byte vRVersionField;

        private bool vRVersionFieldSpecified;

        private bool isFatalErrorField;

        private string errorStatusField;

        private string errorSeverityField;

        private string shortDescriptionField;

        private string longDescriptionField;

        private string vRTypeField;

        private string ownerField;

        private string formulaLeftField;

        private byte formulaRightField;

        private bool formulaRightFieldSpecified;

        private string operatorField;

        private string runCriterionField;

        private string preConditionField;

        private SubaAcknowledgementErrorValueLeft valueLeftField;

        private SubaAcknowledgementErrorValueRight valueRightField;

        private decimal differenceField;

        private byte differencePercentageField;

        private string formulaExpressionField;

        private SubaAcknowledgementErrorObservation observationField;

        /// <remarks/>
        public string ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        public byte VRVersion
        {
            get
            {
                return this.vRVersionField;
            }
            set
            {
                this.vRVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VRVersionSpecified
        {
            get
            {
                return this.vRVersionFieldSpecified;
            }
            set
            {
                this.vRVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsFatalError
        {
            get
            {
                return this.isFatalErrorField;
            }
            set
            {
                this.isFatalErrorField = value;
            }
        }

        /// <remarks/>
        public string ErrorStatus
        {
            get
            {
                return this.errorStatusField;
            }
            set
            {
                this.errorStatusField = value;
            }
        }

        /// <remarks/>
        public string ErrorSeverity
        {
            get
            {
                return this.errorSeverityField;
            }
            set
            {
                this.errorSeverityField = value;
            }
        }

        /// <remarks/>
        public string ShortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        public string LongDescription
        {
            get
            {
                return this.longDescriptionField;
            }
            set
            {
                this.longDescriptionField = value;
            }
        }

        /// <remarks/>
        public string VRType
        {
            get
            {
                return this.vRTypeField;
            }
            set
            {
                this.vRTypeField = value;
            }
        }

        /// <remarks/>
        public string Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public string FormulaLeft
        {
            get
            {
                return this.formulaLeftField;
            }
            set
            {
                this.formulaLeftField = value;
            }
        }

        /// <remarks/>
        public byte FormulaRight
        {
            get
            {
                return this.formulaRightField;
            }
            set
            {
                this.formulaRightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormulaRightSpecified
        {
            get
            {
                return this.formulaRightFieldSpecified;
            }
            set
            {
                this.formulaRightFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }

        /// <remarks/>
        public string RunCriterion
        {
            get
            {
                return this.runCriterionField;
            }
            set
            {
                this.runCriterionField = value;
            }
        }

        /// <remarks/>
        public string PreCondition
        {
            get
            {
                return this.preConditionField;
            }
            set
            {
                this.preConditionField = value;
            }
        }

        /// <remarks/>
        public SubaAcknowledgementErrorValueLeft ValueLeft
        {
            get
            {
                return this.valueLeftField;
            }
            set
            {
                this.valueLeftField = value;
            }
        }

        /// <remarks/>
        public SubaAcknowledgementErrorValueRight ValueRight
        {
            get
            {
                return this.valueRightField;
            }
            set
            {
                this.valueRightField = value;
            }
        }

        /// <remarks/>
        public decimal Difference
        {
            get
            {
                return this.differenceField;
            }
            set
            {
                this.differenceField = value;
            }
        }

        /// <remarks/>
        public byte DifferencePercentage
        {
            get
            {
                return this.differencePercentageField;
            }
            set
            {
                this.differencePercentageField = value;
            }
        }

        /// <remarks/>
        public string FormulaExpression
        {
            get
            {
                return this.formulaExpressionField;
            }
            set
            {
                this.formulaExpressionField = value;
            }
        }

        /// <remarks/>
        public SubaAcknowledgementErrorObservation Observation
        {
            get
            {
                return this.observationField;
            }
            set
            {
                this.observationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementErrorValueLeft
    {

        private string typeField;

        private byte lowField;

        private byte upField;

        private byte valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte up
        {
            get
            {
                return this.upField;
            }
            set
            {
                this.upField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementErrorValueRight
    {

        private string typeField;

        private byte lowField;

        private byte upField;

        private byte valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte up
        {
            get
            {
                return this.upField;
            }
            set
            {
                this.upField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementErrorObservation
    {

        private string tsrc_descrField;

        private string dp_descrField;

        private string variableField;

        private SubaAcknowledgementErrorObservationValue valueField;

        /// <remarks/>
        public string tsrc_descr
        {
            get
            {
                return this.tsrc_descrField;
            }
            set
            {
                this.tsrc_descrField = value;
            }
        }

        /// <remarks/>
        public string dp_descr
        {
            get
            {
                return this.dp_descrField;
            }
            set
            {
                this.dp_descrField = value;
            }
        }

        /// <remarks/>
        public string variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        public SubaAcknowledgementErrorObservationValue value
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.stats.ecb.europa.eu/ssm/suba/acknowledgement")]
    public partial class SubaAcknowledgementErrorObservationValue
    {

        private string unitField;

        private sbyte decimalsField;

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte decimals
        {
            get
            {
                return this.decimalsField;
            }
            set
            {
                this.decimalsField = value;
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
