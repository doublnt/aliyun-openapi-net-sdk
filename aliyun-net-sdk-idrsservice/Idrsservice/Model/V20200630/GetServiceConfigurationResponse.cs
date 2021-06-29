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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class GetServiceConfigurationResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetServiceConfiguration_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public GetServiceConfiguration_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetServiceConfiguration_Data
		{

			private int? clientQueueSize;

			private bool? liveRecordAll;

			private bool? liveRecordEveryOne;

			private int? liveRecordLayout;

			private string liveRecordTaskProfile;

			private int? taskItemQueueSize;

			private int? liveRecordMaxClient;

			private int? liveRecordVideoResolution;

			public int? ClientQueueSize
			{
				get
				{
					return clientQueueSize;
				}
				set	
				{
					clientQueueSize = value;
				}
			}

			public bool? LiveRecordAll
			{
				get
				{
					return liveRecordAll;
				}
				set	
				{
					liveRecordAll = value;
				}
			}

			public bool? LiveRecordEveryOne
			{
				get
				{
					return liveRecordEveryOne;
				}
				set	
				{
					liveRecordEveryOne = value;
				}
			}

			public int? LiveRecordLayout
			{
				get
				{
					return liveRecordLayout;
				}
				set	
				{
					liveRecordLayout = value;
				}
			}

			public string LiveRecordTaskProfile
			{
				get
				{
					return liveRecordTaskProfile;
				}
				set	
				{
					liveRecordTaskProfile = value;
				}
			}

			public int? TaskItemQueueSize
			{
				get
				{
					return taskItemQueueSize;
				}
				set	
				{
					taskItemQueueSize = value;
				}
			}

			public int? LiveRecordMaxClient
			{
				get
				{
					return liveRecordMaxClient;
				}
				set	
				{
					liveRecordMaxClient = value;
				}
			}

			public int? LiveRecordVideoResolution
			{
				get
				{
					return liveRecordVideoResolution;
				}
				set	
				{
					liveRecordVideoResolution = value;
				}
			}
		}
	}
}
