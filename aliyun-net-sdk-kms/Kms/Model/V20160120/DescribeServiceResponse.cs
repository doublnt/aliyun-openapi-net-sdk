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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class DescribeServiceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeService_ProtectionLevel> protectionLevels;

		private List<DescribeService_KeySpec> keySpecs;

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

		public List<DescribeService_ProtectionLevel> ProtectionLevels
		{
			get
			{
				return protectionLevels;
			}
			set	
			{
				protectionLevels = value;
			}
		}

		public List<DescribeService_KeySpec> KeySpecs
		{
			get
			{
				return keySpecs;
			}
			set	
			{
				keySpecs = value;
			}
		}

		public class DescribeService_ProtectionLevel
		{

			private string type;

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
		}

		public class DescribeService_KeySpec
		{

			private string name;

			private List<string> supportedProtectionLevels;

			private List<string> usages;

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

			public List<string> SupportedProtectionLevels
			{
				get
				{
					return supportedProtectionLevels;
				}
				set	
				{
					supportedProtectionLevels = value;
				}
			}

			public List<string> Usages
			{
				get
				{
					return usages;
				}
				set	
				{
					usages = value;
				}
			}
		}
	}
}
