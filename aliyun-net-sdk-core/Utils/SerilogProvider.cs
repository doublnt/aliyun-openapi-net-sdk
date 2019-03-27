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

using Serilog;

namespace Aliyun.Acs.Core.Utils
{
    public class SerilogProvider
    {
        private readonly static string LogTemplate = "[{time}] {channel} {level}: '{method} {uri} HTTP/{version}' {code} {cost}ms {MachineName} {ProcessId} {ThreadId}";
        private static ILogger _logger = null;

        public static void SetLogger(ILogger logger)
        {
            _logger = logger;
        }

        public static void OutputLogInfo(string startTime, string channel, string level, string method, string uri, string version, string statusCode, string excuteTime)
        {
            _logger.Information(LogTemplate, startTime, channel, level, method, uri, version, statusCode, excuteTime);
        }
    }
}
