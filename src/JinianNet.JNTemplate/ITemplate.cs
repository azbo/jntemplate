/*****************************************************
   Copyright (c) 2013-2015 jiniannet (http://www.jiniannet.com)

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

   Redistributions of source code must retain the above copyright notice
 *****************************************************/
using System;
using System.IO;

namespace JinianNet.JNTemplate
{
    /// <summary>
    /// Template 接口
    /// </summary>
    public interface ITemplate
    {
        /// <summary>
        /// 模板上下文
        /// </summary>
        TemplateContext Context { get;set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        String TemplateContent { get;set; }
        /// <summary>
        /// 结果呈现
        /// </summary>
        /// <param name="writer"></param>
        void Render(TextWriter writer);
    }
}
