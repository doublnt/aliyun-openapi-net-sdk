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
	public class QueryAllCinemasResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private string logsId;

		private bool? success;

		private long? totalCount;

		private List<QueryAllCinemas_Cinema> cinemas;

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

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<QueryAllCinemas_Cinema> Cinemas
		{
			get
			{
				return cinemas;
			}
			set	
			{
				cinemas = value;
			}
		}

		public class QueryAllCinemas_Cinema
		{

			private long? cityId;

			private string cityName;

			private long? scheduleCloseTime;

			private string latitude;

			private string longitude;

			private string cinemaName;

			private string address;

			private long? id;

			private string phone;

			private string standardId;

			public long? CityId
			{
				get
				{
					return cityId;
				}
				set	
				{
					cityId = value;
				}
			}

			public string CityName
			{
				get
				{
					return cityName;
				}
				set	
				{
					cityName = value;
				}
			}

			public long? ScheduleCloseTime
			{
				get
				{
					return scheduleCloseTime;
				}
				set	
				{
					scheduleCloseTime = value;
				}
			}

			public string Latitude
			{
				get
				{
					return latitude;
				}
				set	
				{
					latitude = value;
				}
			}

			public string Longitude
			{
				get
				{
					return longitude;
				}
				set	
				{
					longitude = value;
				}
			}

			public string CinemaName
			{
				get
				{
					return cinemaName;
				}
				set	
				{
					cinemaName = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
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

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}

			public string StandardId
			{
				get
				{
					return standardId;
				}
				set	
				{
					standardId = value;
				}
			}
		}
	}
}
