using UnityEngine;
using QFramework;
using UniRx;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class Vegetables : ViewController
	{
		void Start()
		{
			// Code Here
		}

		private void OnMouseDown() {
			Observable.EveryUpdate()
			.First()
			.Subscribe(_=>{
				UIKit.OpenPanel<UITitlePanel>();
				UIKit.GetPanel<UITitlePanel>().title.Value="只是一些蔬菜，并没有什么奇怪的";
				SelectToolsName.Instance().selectToolOpen=false;
			});
		}

	}
}
