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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListExecutionLogsResponse : AcsResponse
	{

		private string requestId;

		private int? maxResults;

		private string nextToken;

		private bool? isTruncated;

		private List<ListExecutionLogs_ExecutionLog> executionLogs;

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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public List<ListExecutionLogs_ExecutionLog> ExecutionLogs
		{
			get
			{
				return executionLogs;
			}
			set	
			{
				executionLogs = value;
			}
		}

		public class ListExecutionLogs_ExecutionLog
		{

			private string timestamp;

			private string message;

			private string taskExecutionId;

			private string logType;

			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
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

			public string TaskExecutionId
			{
				get
				{
					return taskExecutionId;
				}
				set	
				{
					taskExecutionId = value;
				}
			}

			public string LogType
			{
				get
				{
					return logType;
				}
				set	
				{
					logType = value;
				}
			}
		}
	}
}
