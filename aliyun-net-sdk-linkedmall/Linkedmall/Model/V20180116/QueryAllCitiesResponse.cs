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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryAllCitiesResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private string logsId;

		private bool? success;

		private List<QueryAllCities_City> cities;

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

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMessage
		{
			get
			{
				return subMessage;
			}
			set	
			{
				subMessage = value;
			}
		}

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<QueryAllCities_City> Cities
		{
			get
			{
				return cities;
			}
			set	
			{
				cities = value;
			}
		}

		public class QueryAllCities_City
		{

			private string pinYin;

			private long? cityCode;

			private string name;

			private long? id;

			private long? parentId;

			public string PinYin
			{
				get
				{
					return pinYin;
				}
				set	
				{
					pinYin = value;
				}
			}

			public long? CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

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

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public long? ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}
		}
	}
}
