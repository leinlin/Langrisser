using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002FB RID: 763
	[ProtoContract(Name = "GetPathData")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GetPathData : IExtensible
	{
		// Token: 0x06002DF5 RID: 11765 RVA: 0x000B8230 File Offset: 0x000B6430
		public GetPathData()
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

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x000B8298 File Offset: 0x000B6498
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x000B82A0 File Offset: 0x000B64A0
		[ProtoMember(1, IsRequired = true, Name = "PathType", DataFormat = DataFormat.TwosComplement)]
		public GetPathType PathType
		{
			get
			{
				return this._PathType;
			}
			set
			{
				this._PathType = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x000B82AC File Offset: 0x000B64AC
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x000B82B4 File Offset: 0x000B64B4
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000B82C0 File Offset: 0x000B64C0
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x000B82C8 File Offset: 0x000B64C8
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.TwosComplement)]
		public int Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x000B82D4 File Offset: 0x000B64D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000B82E4 File Offset: 0x000B64E4
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

		// Token: 0x06002DFE RID: 11774 RVA: 0x000B83B0 File Offset: 0x000B65B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetPathData));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002349 RID: 9033
		private GetPathType _PathType;

		// Token: 0x0400234A RID: 9034
		private int _ID;

		// Token: 0x0400234B RID: 9035
		private int _Name;

		// Token: 0x0400234C RID: 9036
		private IExtension extensionObject;

		// Token: 0x0400234D RID: 9037
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400234E RID: 9038
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400234F RID: 9039
		private LuaFunction m_ctor_hotfix;
	}
}
