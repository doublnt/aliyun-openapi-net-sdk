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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetMetaTableOutputResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private bool? success;

		private GetMetaTableOutput_Data data;

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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetMetaTableOutput_Data Data
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

		public class GetMetaTableOutput_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private long? totalCount;

			private List<GetMetaTableOutput_DataEntityListItem> dataEntityList;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public List<GetMetaTableOutput_DataEntityListItem> DataEntityList
			{
				get
				{
					return dataEntityList;
				}
				set	
				{
					dataEntityList = value;
				}
			}

			public class GetMetaTableOutput_DataEntityListItem
			{

				private string tableGuid;

				private string taskId;

				private string startTime;

				private string endTime;

				private string waitTime;

				private long? projectId;

				private long? taskInstanceId;

				public string TableGuid
				{
					get
					{
						return tableGuid;
					}
					set	
					{
						tableGuid = value;
					}
				}

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string WaitTime
				{
					get
					{
						return waitTime;
					}
					set	
					{
						waitTime = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public long? TaskInstanceId
				{
					get
					{
						return taskInstanceId;
					}
					set	
					{
						taskInstanceId = value;
					}
				}
			}
		}
	}
}
