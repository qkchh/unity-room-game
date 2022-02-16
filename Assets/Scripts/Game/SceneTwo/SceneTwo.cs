using UnityEngine;
using QFramework;
using UniRx;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.Example
{
	public partial class SceneTwo : ViewController
	{
		void Start()
		{
			// Code Here
			//把场景二预制体加入到字典
			Scenes.Instance().scene.Add("SceneTwo",gameObject);

			//判断是又窗帘，给数字添加组件
			Observable.EveryUpdate()
			.Where(_=>(CurtainBig.GetComponent<SpriteRenderer>().sprite.name.Equals("CurtainSmall")))
			.First()
			.Subscribe(_=>{
				//窗帘控件关闭
				CurtainBig.GetComponent<BoxCollider2D>().enabled=false;
				//激活数字组件
				number0956.gameObject.AddComponent<BoxCollider2D>();
			});
		}
	}
}
