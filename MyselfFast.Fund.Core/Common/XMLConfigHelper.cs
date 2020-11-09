using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace myselfFast.Fund.Core.Common
{
    public class XMLConfigHelper
    {
        /// <summary>
        /// 根据Key取Value值
        /// </summary>
        /// <param name="key"></param>
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString().Trim();
        }

        /// <summary>
        /// 根据Key修改Value
        /// </summary>
        /// <param name="key">要修改的Key</param>
        /// <param name="value">要修改为的值</param>
        public static void SetValue(string key, string value)
        {
            ConfigurationManager.AppSettings.Set(key, value);
        }

        /// <summary>
        /// 添加新的Key ，Value键值对
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void Add(string key, string value)
        {
            ConfigurationManager.AppSettings.Add(key, value);
        }

        /// <summary>
        /// 根据Key删除项
        /// </summary>
        /// <param name="key">Key</param>
        public static void Remove(string key)
        {
            ConfigurationManager.AppSettings.Remove(key);
        }
        /// <summary>
        /// 单独xml配置文件节点获取
        /// </summary>
        /// <param name="configPath">xml文件路径</param>
        /// <param name="nodeName">要获取的节点名称</param>
        /// <returns></returns>
        public static XmlNode FindElements(string configPath, string nodeName)
        {
            XmlNode result = null;

            if (string.IsNullOrEmpty(configPath) && File.Exists(configPath) && string.IsNullOrEmpty(nodeName))
            {
                XmlDocument document = new XmlDocument();
                document.Load(configPath);
                var node = VisitorNode(document.DocumentElement, nodeName);
                if (node != null)
                {
                    result = node;
                }
            }
            return result;
        }


        private static XmlNode VisitorNode(XmlNode node, string nodeName)
        {
            if (string.Compare(node.Name, nodeName) == 0)
            {
                return node;
            }
            else
            {
                if (node.HasChildNodes)
                {
                    var nodes = node.ChildNodes;
                    foreach (XmlNode childNode in nodes)
                    {
                        var tempNode = VisitorNode(childNode, nodeName);
                        if (tempNode != null)
                            return tempNode;

                    }
                }
            }
            return null;
        }
    }
}
