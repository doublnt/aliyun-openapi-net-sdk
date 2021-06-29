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

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
	public class GetMetadataAmountResponse : AcsResponse
	{

		private string requestId;

		private GetMetadataAmount_Data data;

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

		public GetMetadataAmount_Data Data
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

		public class GetMetadataAmount_Data
		{

			private int? currentVirtualHosts;

			private int? maxVirtualHosts;

			private int? currentExchanges;

			private int? maxExchanges;

			private int? currentQueues;

			private int? maxQueues;

			public int? CurrentVirtualHosts
			{
				get
				{
					return currentVirtualHosts;
				}
				set	
				{
					currentVirtualHosts = value;
				}
			}

			public int? MaxVirtualHosts
			{
				get
				{
					return maxVirtualHosts;
				}
				set	
				{
					maxVirtualHosts = value;
				}
			}

			public int? CurrentExchanges
			{
				get
				{
					return currentExchanges;
				}
				set	
				{
					currentExchanges = value;
				}
			}

			public int? MaxExchanges
			{
				get
				{
					return maxExchanges;
				}
				set	
				{
					maxExchanges = value;
				}
			}

			public int? CurrentQueues
			{
				get
				{
					return currentQueues;
				}
				set	
				{
					currentQueues = value;
				}
			}

			public int? MaxQueues
			{
				get
				{
					return maxQueues;
				}
				set	
				{
					maxQueues = value;
				}
			}
		}
	}
}
