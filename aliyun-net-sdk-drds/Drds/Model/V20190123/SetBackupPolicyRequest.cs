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
using Aliyun.Acs.Drds.Transform;
using Aliyun.Acs.Drds.Transform.V20190123;

namespace Aliyun.Acs.Drds.Model.V20190123
{
    public class SetBackupPolicyRequest : RpcAcsRequest<SetBackupPolicyResponse>
    {
        public SetBackupPolicyRequest()
            : base("Drds", "2019-01-23", "SetBackupPolicy", "drds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Drds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string backupDbNames;

		private string backupLog;

		private string preferredBackupEndTime;

		private string preferredBackupPeriod;

		private string preferredBackupStartTime;

		private string backupLevel;

		private string drdsInstanceId;

		private string dataBackupRetentionPeriod;

		private string backupMode;

		private string logBackupRetentionPeriod;

		public string BackupDbNames
		{
			get
			{
				return backupDbNames;
			}
			set	
			{
				backupDbNames = value;
				DictionaryUtil.Add(QueryParameters, "BackupDbNames", value);
			}
		}

		public string BackupLog
		{
			get
			{
				return backupLog;
			}
			set	
			{
				backupLog = value;
				DictionaryUtil.Add(QueryParameters, "BackupLog", value);
			}
		}

		public string PreferredBackupEndTime
		{
			get
			{
				return preferredBackupEndTime;
			}
			set	
			{
				preferredBackupEndTime = value;
				DictionaryUtil.Add(QueryParameters, "PreferredBackupEndTime", value);
			}
		}

		public string PreferredBackupPeriod
		{
			get
			{
				return preferredBackupPeriod;
			}
			set	
			{
				preferredBackupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "PreferredBackupPeriod", value);
			}
		}

		public string PreferredBackupStartTime
		{
			get
			{
				return preferredBackupStartTime;
			}
			set	
			{
				preferredBackupStartTime = value;
				DictionaryUtil.Add(QueryParameters, "PreferredBackupStartTime", value);
			}
		}

		public string BackupLevel
		{
			get
			{
				return backupLevel;
			}
			set	
			{
				backupLevel = value;
				DictionaryUtil.Add(QueryParameters, "BackupLevel", value);
			}
		}

		public string DrdsInstanceId
		{
			get
			{
				return drdsInstanceId;
			}
			set	
			{
				drdsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DrdsInstanceId", value);
			}
		}

		public string DataBackupRetentionPeriod
		{
			get
			{
				return dataBackupRetentionPeriod;
			}
			set	
			{
				dataBackupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "DataBackupRetentionPeriod", value);
			}
		}

		public string BackupMode
		{
			get
			{
				return backupMode;
			}
			set	
			{
				backupMode = value;
				DictionaryUtil.Add(QueryParameters, "BackupMode", value);
			}
		}

		public string LogBackupRetentionPeriod
		{
			get
			{
				return logBackupRetentionPeriod;
			}
			set	
			{
				logBackupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "LogBackupRetentionPeriod", value);
			}
		}

        public override SetBackupPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetBackupPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
