using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;

using Umbraco.Core;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;
using umbraco.BusinessLogic.Actions;

[PluginController("CustomSection")]
[Umbraco.Web.Trees.Tree("CustomSection", "CustomSectionTree","My custom section", iconClosed: "icon-doc")]
public class CustomSectionTreeController : TreeController
{
    protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
    {
        var nodes = new TreeNodeCollection();
        var item = this.CreateTreeNode("dashboard", id, queryStrings, "My item", "icon-truck", true);
        nodes.Add(item);
        return nodes;
    }
 
    protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
    {
       var menu = new MenuItemCollection();
     //  menu.DefaultMenuAlias = ActionNew.Instance.Alias;
	//     menu.Items.Add<ActionNew>("Create");
        return menu;
    }
}