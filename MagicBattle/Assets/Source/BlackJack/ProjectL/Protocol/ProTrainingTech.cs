using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200067A RID: 1658
	[ProtoContract(Name = "ProTrainingTech")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProTrainingTech : IExtensible
	{
		// Token: 0x06005A58 RID: 23128 RVA: 0x0019FE90 File Offset: 0x0019E090
		public ProTrainingTech()
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

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x0019FEF8 File Offset: 0x0019E0F8
		// (set) Token: 0x06005A5A RID: 23130 RVA: 0x0019FF00 File Offset: 0x0019E100
		[ProtoMember(1, IsRequired = true, Name = "ConfigId", DataFormat = DataFormat.TwosComplement)]
		public int ConfigId
		{
			get
			{
				return this._ConfigId;
			}
			set
			{
				this._ConfigId = value;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x0019FF0C File Offset: 0x0019E10C
		// (set) Token: 0x06005A5C RID: 23132 RVA: 0x0019FF14 File Offset: 0x0019E114
		[ProtoMember(2, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x0019FF20 File Offset: 0x0019E120
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x0019FF30 File Offset: 0x0019E130
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

		// Token: 0x06005A5F RID: 23135 RVA: 0x0019FFFC File Offset: 0x0019E1FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTrainingTech));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043B0 RID: 17328
		private int _ConfigId;

		// Token: 0x040043B1 RID: 17329
		private int _Level;

		// Token: 0x040043B2 RID: 17330
		private IExtension extensionObject;

		// Token: 0x040043B3 RID: 17331
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043B4 RID: 17332
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043B5 RID: 17333
		private LuaFunction m_ctor_hotfix;
	}
}
