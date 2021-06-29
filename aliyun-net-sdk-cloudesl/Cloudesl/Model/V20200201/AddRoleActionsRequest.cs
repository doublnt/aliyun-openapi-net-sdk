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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class AddRoleActionsRequest : RpcAcsRequest<AddRoleActionsResponse>
    {
        public AddRoleActionsRequest()
            : base("cloudesl", "2020-02-01", "AddRoleActions", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string roleCode;

		private string extraParams;

		private string clientToken;

		private string accessControlLists;

		public string RoleCode
		{
			get
			{
				return roleCode;
			}
			set	
			{
				roleCode = value;
				DictionaryUtil.Add(BodyParameters, "RoleCode", value);
			}
		}

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
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
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
			}
		}

		public string AccessControlLists
		{
			get
			{
				return accessControlLists;
			}
			set	
			{
				accessControlLists = value;
				DictionaryUtil.Add(BodyParameters, "AccessControlLists", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddRoleActionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddRoleActionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}