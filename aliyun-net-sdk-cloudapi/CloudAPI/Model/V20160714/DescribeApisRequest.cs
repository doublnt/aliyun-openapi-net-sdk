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
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class DescribeApisRequest : RpcAcsRequest<DescribeApisResponse>
    {
        public DescribeApisRequest()
            : base("CloudAPI", "2016-07-14", "DescribeApis", "apigateway", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string visibility;

		private string groupId;

		private bool? enableTagAuth;

		private int? pageNumber;

		private string apiName;

		private string catalogId;

		private string securityToken;

		private int? pageSize;

		private List<Tag> tags = new List<Tag>(){ };

		private string apiId;

		public string Visibility
		{
			get
			{
				return visibility;
			}
			set	
			{
				visibility = value;
				DictionaryUtil.Add(QueryParameters, "Visibility", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public bool? EnableTagAuth
		{
			get
			{
				return enableTagAuth;
			}
			set	
			{
				enableTagAuth = value;
				DictionaryUtil.Add(QueryParameters, "EnableTagAuth", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string ApiName
		{
			get
			{
				return apiName;
			}
			set	
			{
				apiName = value;
				DictionaryUtil.Add(QueryParameters, "ApiName", value);
			}
		}

		public string CatalogId
		{
			get
			{
				return catalogId;
			}
			set	
			{
				catalogId = value;
				DictionaryUtil.Add(QueryParameters, "CatalogId", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public string ApiId
		{
			get
			{
				return apiId;
			}
			set	
			{
				apiId = value;
				DictionaryUtil.Add(QueryParameters, "ApiId", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

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
		}

        public override DescribeApisResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeApisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
