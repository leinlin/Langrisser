using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000289 RID: 649
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSensitiveWords")]
	[Serializable]
	public class ConfigDataSensitiveWords : IExtensible
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x000B0DF4 File Offset: 0x000AEFF4
		public ConfigDataSensitiveWords()
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000B0E5C File Offset: 0x000AF05C
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x000B0E64 File Offset: 0x000AF064
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000B0E70 File Offset: 0x000AF070
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x000B0E78 File Offset: 0x000AF078
		[ProtoMember(3, IsRequired = true, Name = "Text", DataFormat = DataFormat.Default)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				this._Text = value;
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000B0E84 File Offset: 0x000AF084
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000B0E94 File Offset: 0x000AF094
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

		// Token: 0x06002A23 RID: 10787 RVA: 0x000B0F60 File Offset: 0x000AF160
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSensitiveWords));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019F1 RID: 6641
		private int _ID;

		// Token: 0x040019F2 RID: 6642
		private string _Text;

		// Token: 0x040019F3 RID: 6643
		private IExtension extensionObject;

		// Token: 0x040019F4 RID: 6644
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019F5 RID: 6645
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019F6 RID: 6646
		private LuaFunction m_ctor_hotfix;
	}
}
