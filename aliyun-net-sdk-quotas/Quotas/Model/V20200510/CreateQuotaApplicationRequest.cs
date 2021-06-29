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
using Aliyun.Acs.quotas.Transform;
using Aliyun.Acs.quotas.Transform.V20200510;

namespace Aliyun.Acs.quotas.Model.V20200510
{
    public class CreateQuotaApplicationRequest : RpcAcsRequest<CreateQuotaApplicationResponse>
    {
        public CreateQuotaApplicationRequest()
            : base("quotas", "2020-05-10", "CreateQuotaApplication", "quotas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reason;

		private string productCode;

		private string quotaActionCode;

		private float? desireValue;

		private string quotaCategory;

		private int? noticeType;

		private string auditMode;

		private List<Dimensions> dimensionss = new List<Dimensions>(){ };

		public string Reason
		{
			get
			{
				return reason;
			}
			set	
			{
				reason = value;
				DictionaryUtil.Add(BodyParameters, "Reason", value);
			}
		}

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(BodyParameters, "ProductCode", value);
			}
		}

		public string QuotaActionCode
		{
			get
			{
				return quotaActionCode;
			}
			set	
			{
				quotaActionCode = value;
				DictionaryUtil.Add(BodyParameters, "QuotaActionCode", value);
			}
		}

		public float? DesireValue
		{
			get
			{
				return desireValue;
			}
			set	
			{
				desireValue = value;
				DictionaryUtil.Add(BodyParameters, "DesireValue", value.ToString());
			}
		}

		public string QuotaCategory
		{
			get
			{
				return quotaCategory;
			}
			set	
			{
				quotaCategory = value;
				DictionaryUtil.Add(BodyParameters, "QuotaCategory", value);
			}
		}

		public int? NoticeType
		{
			get
			{
				return noticeType;
			}
			set	
			{
				noticeType = value;
				DictionaryUtil.Add(BodyParameters, "NoticeType", value.ToString());
			}
		}

		public string AuditMode
		{
			get
			{
				return auditMode;
			}
			set	
			{
				auditMode = value;
				DictionaryUtil.Add(BodyParameters, "AuditMode", value);
			}
		}

		public List<Dimensions> Dimensionss
		{
			get
			{
				return dimensionss;
			}

			set
			{
				dimensionss = value;
				for (int i = 0; i < dimensionss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Dimensions." + (i + 1) + ".Key", dimensionss[i].Key);
					DictionaryUtil.Add(BodyParameters,"Dimensions." + (i + 1) + ".Value", dimensionss[i].Value);
				}
			}
		}

		public class Dimensions
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateQuotaApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateQuotaApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}