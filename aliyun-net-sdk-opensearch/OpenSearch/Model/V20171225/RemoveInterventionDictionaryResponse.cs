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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class RemoveInterventionDictionaryResponse : AcsResponse
	{

		private string requestId;

		private RemoveInterventionDictionary_Result result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public RemoveInterventionDictionary_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class RemoveInterventionDictionary_Result
		{

			private string name;

			private string type;

			private string analyzer;

			private string created;

			private string updated;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Analyzer
			{
				get
				{
					return analyzer;
				}
				set	
				{
					analyzer = value;
				}
			}

			public string Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public string Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
				}
			}
		}
	}
}
