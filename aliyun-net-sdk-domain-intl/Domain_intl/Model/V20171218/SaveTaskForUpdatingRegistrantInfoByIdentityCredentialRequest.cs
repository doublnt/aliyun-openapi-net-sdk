/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest : RpcAcsRequest<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse>
    {
        public SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest()
            : base("Domain-intl", "2017-12-18", "SaveTaskForUpdatingRegistrantInfoByIdentityCredential", "domain", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string country;

		private string identityCredentialType;

		private string city;

		private string identityCredential;

		private bool? transferOutProhibited;

		private string telExt;

		private string province;

		private string postalCode;

		private string lang;

		private string email;

		private string address;

		private string telArea;

		private string registrantType;

		private List<string> domainNames = new List<string>(){ };

		private string telephone;

		private string registrantOrganization;

		private string userClientIp;

		private string identityCredentialNo;

		private string registrantName;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		public string IdentityCredentialType
		{
			get
			{
				return identityCredentialType;
			}
			set	
			{
				identityCredentialType = value;
				DictionaryUtil.Add(QueryParameters, "IdentityCredentialType", value);
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public string IdentityCredential
		{
			get
			{
				return identityCredential;
			}
			set	
			{
				identityCredential = value;
				DictionaryUtil.Add(BodyParameters, "IdentityCredential", value);
			}
		}

		public bool? TransferOutProhibited
		{
			get
			{
				return transferOutProhibited;
			}
			set	
			{
				transferOutProhibited = value;
				DictionaryUtil.Add(QueryParameters, "TransferOutProhibited", value.ToString());
			}
		}

		public string TelExt
		{
			get
			{
				return telExt;
			}
			set	
			{
				telExt = value;
				DictionaryUtil.Add(QueryParameters, "TelExt", value);
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(QueryParameters, "Province", value);
			}
		}

		public string PostalCode
		{
			get
			{
				return postalCode;
			}
			set	
			{
				postalCode = value;
				DictionaryUtil.Add(QueryParameters, "PostalCode", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		public string TelArea
		{
			get
			{
				return telArea;
			}
			set	
			{
				telArea = value;
				DictionaryUtil.Add(QueryParameters, "TelArea", value);
			}
		}

		public string RegistrantType
		{
			get
			{
				return registrantType;
			}
			set	
			{
				registrantType = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantType", value);
			}
		}

		public List<string> DomainNames
		{
			get
			{
				return domainNames;
			}

			set
			{
				domainNames = value;
				for (int i = 0; i < domainNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DomainName." + (i + 1) , domainNames[i]);
				}
			}
		}

		public string Telephone
		{
			get
			{
				return telephone;
			}
			set	
			{
				telephone = value;
				DictionaryUtil.Add(QueryParameters, "Telephone", value);
			}
		}

		public string RegistrantOrganization
		{
			get
			{
				return registrantOrganization;
			}
			set	
			{
				registrantOrganization = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantOrganization", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string IdentityCredentialNo
		{
			get
			{
				return identityCredentialNo;
			}
			set	
			{
				identityCredentialNo = value;
				DictionaryUtil.Add(QueryParameters, "IdentityCredentialNo", value);
			}
		}

		public string RegistrantName
		{
			get
			{
				return registrantName;
			}
			set	
			{
				registrantName = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
