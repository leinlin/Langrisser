using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000332 RID: 818
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataScene3DInfo")]
	[Serializable]
	public class ConfigDataScene3DInfo : IExtensible
	{
		// Token: 0x060030A5 RID: 12453 RVA: 0x000BF16C File Offset: 0x000BD36C
		public ConfigDataScene3DInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x000BF1E8 File Offset: 0x000BD3E8
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x000BF1F0 File Offset: 0x000BD3F0
		[ProtoMember(1, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x000BF1FC File Offset: 0x000BD3FC
		[ProtoMember(2, Name = "sceneObjectList", DataFormat = DataFormat.Default)]
		public List<SceneObject3DInfo> SceneObjectList
		{
			get
			{
				return this._sceneObjectList;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000BF204 File Offset: 0x000BD404
		[ProtoMember(3, Name = "dummyObjectList", DataFormat = DataFormat.Default)]
		public List<SceneDummyObjectInfo> DummyObjectList
		{
			get
			{
				return this._dummyObjectList;
			}
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x000BF20C File Offset: 0x000BD40C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x000BF21C File Offset: 0x000BD41C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x000BF2E8 File Offset: 0x000BD4E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataScene3DInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002515 RID: 9493
		private int _ID;

		// Token: 0x04002516 RID: 9494
		private readonly List<SceneObject3DInfo> _sceneObjectList = new List<SceneObject3DInfo>();

		// Token: 0x04002517 RID: 9495
		private readonly List<SceneDummyObjectInfo> _dummyObjectList = new List<SceneDummyObjectInfo>();

		// Token: 0x04002518 RID: 9496
		private IExtension extensionObject;

		// Token: 0x04002519 RID: 9497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400251A RID: 9498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400251B RID: 9499
		private LuaFunction m_ctor_hotfix;
	}
}
