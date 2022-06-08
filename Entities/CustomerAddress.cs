//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

//------------------------------------------------------------------------------


namespace Xrm
{
	
	/// <summary>
	/// Address and shipping information. Used to store additional addresses for an account or contact.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customeraddress")]
	public partial class CustomerAddress : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerAddress() : 
				base(EntityLogicalName)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerAddress(System.Guid id) : 
				base(EntityLogicalName, id)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerAddress(string keyName, object keyValue) : 
				base(EntityLogicalName, keyName, keyValue)
		{
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerAddress(Microsoft.Xrm.Sdk.KeyAttributeCollection keyAttributes) : 
				base(EntityLogicalName, keyAttributes)
		{
		}
		
		public const string EntityLogicalName = "customeraddress";
		
		public const string EntitySchemaName = "CustomerAddress";
		
		public const string PrimaryIdAttribute = "customeraddressid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "customeraddresses";
		
		public const string EntitySetName = "customeraddresses";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Shows the number of the address, to indicate whether the address is the primary, secondary, or other address for the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressnumber")]
		public System.Nullable<int> AddressNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("addressnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressNumber");
				this.SetAttributeValue("addressnumber", value);
				this.OnPropertyChanged("AddressNumber");
			}
		}
		
		/// <summary>
		/// Select the address type, such as primary or billing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecode")]
		public virtual CustomerAddress_AddressTypeCode? AddressTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((CustomerAddress_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "addresstypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AddressTypeCode");
				this.SetAttributeValue("addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("AddressTypeCode");
			}
		}
		
		/// <summary>
		/// Type the city for the customer's address to help identify the location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("city")]
		public string City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("City");
				this.SetAttributeValue("city", value);
				this.OnPropertyChanged("City");
			}
		}
		
		/// <summary>
		/// Shows the complete address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("composite")]
		public string Composite
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("composite");
			}
		}
		
		/// <summary>
		/// Type the country or region for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("country")]
		public string Country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Country");
				this.SetAttributeValue("country", value);
				this.OnPropertyChanged("Country");
			}
		}
		
		/// <summary>
		/// Type the county for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("county")]
		public string County
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("County");
				this.SetAttributeValue("county", value);
				this.OnPropertyChanged("County");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier of the customer address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeraddressid")]
		public System.Nullable<System.Guid> CustomerAddressId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("customeraddressid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerAddressId");
				this.SetAttributeValue("customeraddressid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CustomerAddressId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeraddressid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.CustomerAddressId = value;
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Type the fax number associated with the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
		public string Fax
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fax");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Fax");
				this.SetAttributeValue("fax", value);
				this.OnPropertyChanged("Fax");
			}
		}
		
		/// <summary>
		/// Select the freight terms to make sure shipping charges are processed correctly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public virtual CustomerAddress_FreightTermsCode? FreightTermsCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((CustomerAddress_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "freighttermscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				this.SetAttributeValue("freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Type the latitude value for the customer's address, for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("latitude")]
		public System.Nullable<double> Latitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("latitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Latitude");
				this.SetAttributeValue("latitude", value);
				this.OnPropertyChanged("Latitude");
			}
		}
		
		/// <summary>
		/// Type the first line of the customer's address to help identify the location.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line1")]
		public string Line1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("line1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Line1");
				this.SetAttributeValue("line1", value);
				this.OnPropertyChanged("Line1");
			}
		}
		
		/// <summary>
		/// Type the second line of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line2")]
		public string Line2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("line2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Line2");
				this.SetAttributeValue("line2", value);
				this.OnPropertyChanged("Line2");
			}
		}
		
		/// <summary>
		/// Type the third line of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line3")]
		public string Line3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("line3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Line3");
				this.SetAttributeValue("line3", value);
				this.OnPropertyChanged("Line3");
			}
		}
		
		/// <summary>
		/// Type the longitude value for the customer's address, for use in mapping and other applications.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longitude")]
		public System.Nullable<double> Longitude
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("longitude");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Longitude");
				this.SetAttributeValue("longitude", value);
				this.OnPropertyChanged("Longitude");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Type a descriptive name for the customer's address, such as Corporate Headquarters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Shows the type code of the customer record to indicate whether the address belongs to a customer account or contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Shows the business unit that the record owner belongs to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the customer address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Choose the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentId");
				this.SetAttributeValue("parentid", value);
				this.OnPropertyChanged("ParentId");
			}
		}
		
		/// <summary>
		/// Type the ZIP Code or postal code for the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postalcode")]
		public string PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostalCode");
				this.SetAttributeValue("postalcode", value);
				this.OnPropertyChanged("PostalCode");
			}
		}
		
		/// <summary>
		/// Type the post office box number of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postofficebox")]
		public string PostOfficeBox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostOfficeBox");
				this.SetAttributeValue("postofficebox", value);
				this.OnPropertyChanged("PostOfficeBox");
			}
		}
		
		/// <summary>
		/// Type the name of the primary contact person for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactname")]
		public string PrimaryContactName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primarycontactname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryContactName");
				this.SetAttributeValue("primarycontactname", value);
				this.OnPropertyChanged("PrimaryContactName");
			}
		}
		
		/// <summary>
		/// Select a shipping method for deliveries sent to this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual CustomerAddress_ShippingMethodCode? ShippingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((CustomerAddress_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Type the state or province of the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stateorprovince")]
		public string StateOrProvince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stateorprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateOrProvince");
				this.SetAttributeValue("stateorprovince", value);
				this.OnPropertyChanged("StateOrProvince");
			}
		}
		
		/// <summary>
		/// Type the primary phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
		public string Telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone1");
				this.SetAttributeValue("telephone1", value);
				this.OnPropertyChanged("Telephone1");
			}
		}
		
		/// <summary>
		/// Type a second phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
		public string Telephone2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone2");
				this.SetAttributeValue("telephone2", value);
				this.OnPropertyChanged("Telephone2");
			}
		}
		
		/// <summary>
		/// Type a third phone number for the customer's address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
		public string Telephone3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("telephone3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Telephone3");
				this.SetAttributeValue("telephone3", value);
				this.OnPropertyChanged("Telephone3");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Type the UPS zone of the customer's address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upszone")]
		public string UPSZone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("upszone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UPSZone");
				this.SetAttributeValue("upszone", value);
				this.OnPropertyChanged("UPSZone");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Select the time zone for the address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcoffset")]
		public System.Nullable<int> UTCOffset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcoffset");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCOffset");
				this.SetAttributeValue("utcoffset", value);
				this.OnPropertyChanged("UTCOffset");
			}
		}
		
		/// <summary>
		/// Version number of the customer address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 Account_CustomerAddress
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_CustomerAddress")]
		public Xrm.Account Account_CustomerAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Xrm.Account>("Account_CustomerAddress", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Account_CustomerAddress");
				this.SetRelatedEntity<Xrm.Account>("Account_CustomerAddress", null, value);
				this.OnPropertyChanged("Account_CustomerAddress");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerAddress(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["customeraddressid"] = base.Id;
                        break;
                    case "customeraddressid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}