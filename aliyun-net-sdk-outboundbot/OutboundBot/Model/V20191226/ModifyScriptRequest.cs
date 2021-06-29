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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class ModifyScriptRequest : RpcAcsRequest<ModifyScriptResponse>
    {
        public ModifyScriptRequest()
            : base("OutboundBot", "2019-12-26", "ModifyScript", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string industry;

		private string scriptName;

		private string scene;

		private string scriptId;

		private string instanceId;

		private string scriptDescription;

		public string Industry
		{
			get
			{
				return industry;
			}
			set	
			{
				industry = value;
				DictionaryUtil.Add(QueryParameters, "Industry", value);
			}
		}

		public string ScriptName
		{
			get
			{
				return scriptName;
			}
			set	
			{
				scriptName = value;
				DictionaryUtil.Add(QueryParameters, "ScriptName", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public string ScriptId
		{
			get
			{
				return scriptId;
			}
			set	
			{
				scriptId = value;
				DictionaryUtil.Add(QueryParameters, "ScriptId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ScriptDescription
		{
			get
			{
				return scriptDescription;
			}
			set	
			{
				scriptDescription = value;
				DictionaryUtil.Add(QueryParameters, "ScriptDescription", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyScriptResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyScriptResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}