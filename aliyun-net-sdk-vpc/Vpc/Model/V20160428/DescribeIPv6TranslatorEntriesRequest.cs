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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeIPv6TranslatorEntriesRequest : RpcAcsRequest<DescribeIPv6TranslatorEntriesResponse>
    {
        public DescribeIPv6TranslatorEntriesRequest()
            : base("Vpc", "2016-04-28", "DescribeIPv6TranslatorEntries", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? backendIpv4Port;

		private long? resourceOwnerId;

		private string entryName;

		private string clientToken;

		private string aclStatus;

		private int? pageNumber;

		private string aclType;

		private int? allocateIpv6Port;

		private int? pageSize;

		private string backendIpv4Addr;

		private string aclId;

		private string ipv6TranslatorEntryId;

		private string resourceOwnerAccount;

		private string allocateIpv6Addr;

		private string ownerAccount;

		private long? ownerId;

		private string transProtocol;

		private string ipv6TranslatorId;

		public int? BackendIpv4Port
		{
			get
			{
				return backendIpv4Port;
			}
			set	
			{
				backendIpv4Port = value;
				DictionaryUtil.Add(QueryParameters, "BackendIpv4Port", value.ToString());
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string EntryName
		{
			get
			{
				return entryName;
			}
			set	
			{
				entryName = value;
				DictionaryUtil.Add(QueryParameters, "EntryName", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
				DictionaryUtil.Add(QueryParameters, "AclStatus", value);
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

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
				DictionaryUtil.Add(QueryParameters, "AclType", value);
			}
		}

		public int? AllocateIpv6Port
		{
			get
			{
				return allocateIpv6Port;
			}
			set	
			{
				allocateIpv6Port = value;
				DictionaryUtil.Add(QueryParameters, "AllocateIpv6Port", value.ToString());
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

		public string BackendIpv4Addr
		{
			get
			{
				return backendIpv4Addr;
			}
			set	
			{
				backendIpv4Addr = value;
				DictionaryUtil.Add(QueryParameters, "BackendIpv4Addr", value);
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
				DictionaryUtil.Add(QueryParameters, "AclId", value);
			}
		}

		public string Ipv6TranslatorEntryId
		{
			get
			{
				return ipv6TranslatorEntryId;
			}
			set	
			{
				ipv6TranslatorEntryId = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6TranslatorEntryId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string AllocateIpv6Addr
		{
			get
			{
				return allocateIpv6Addr;
			}
			set	
			{
				allocateIpv6Addr = value;
				DictionaryUtil.Add(QueryParameters, "AllocateIpv6Addr", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string TransProtocol
		{
			get
			{
				return transProtocol;
			}
			set	
			{
				transProtocol = value;
				DictionaryUtil.Add(QueryParameters, "TransProtocol", value);
			}
		}

		public string Ipv6TranslatorId
		{
			get
			{
				return ipv6TranslatorId;
			}
			set	
			{
				ipv6TranslatorId = value;
				DictionaryUtil.Add(QueryParameters, "Ipv6TranslatorId", value);
			}
		}

        public override DescribeIPv6TranslatorEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeIPv6TranslatorEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
