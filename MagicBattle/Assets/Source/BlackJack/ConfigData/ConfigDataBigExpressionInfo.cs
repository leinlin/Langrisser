using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000217 RID: 535
	[ProtoContract(Name = "ConfigDataBigExpressionInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBigExpressionInfo : IExtensible
	{
		// Token: 0x06001F34 RID: 7988 RVA: 0x0009EB08 File Offset: 0x0009CD08
		public ConfigDataBigExpressionInfo()
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x0009EB70 File Offset: 0x0009CD70
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x0009EB78 File Offset: 0x0009CD78
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

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0009EB84 File Offset: 0x0009CD84
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x0009EB8C File Offset: 0x0009CD8C
		[ProtoMember(3, IsRequired = true, Name = "ExpressionIconPath", DataFormat = DataFormat.Default)]
		public string ExpressionIconPath
		{
			get
			{
				return this._ExpressionIconPath;
			}
			set
			{
				this._ExpressionIconPath = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0009EB98 File Offset: 0x0009CD98
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0009EBA0 File Offset: 0x0009CDA0
		[ProtoMember(5, IsRequired = true, Name = "Group", DataFormat = DataFormat.TwosComplement)]
		public int Group
		{
			get
			{
				return this._Group;
			}
			set
			{
				this._Group = value;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0009EBAC File Offset: 0x0009CDAC
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0009EBB4 File Offset: 0x0009CDB4
		[ProtoMember(6, IsRequired = true, Name = "ExpressionPurposeType", DataFormat = DataFormat.TwosComplement)]
		public ExpressionPurposeType ExpressionPurposeType
		{
			get
			{
				return this._ExpressionPurposeType;
			}
			set
			{
				this._ExpressionPurposeType = value;
			}
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0009EBC0 File Offset: 0x0009CDC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0009EBD0 File Offset: 0x0009CDD0
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

		// Token: 0x06001F3F RID: 7999 RVA: 0x0009EC9C File Offset: 0x0009CE9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBigExpressionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040012D5 RID: 4821
		private int _ID;

		// Token: 0x040012D6 RID: 4822
		private string _ExpressionIconPath;

		// Token: 0x040012D7 RID: 4823
		private int _Group;

		// Token: 0x040012D8 RID: 4824
		private ExpressionPurposeType _ExpressionPurposeType;

		// Token: 0x040012D9 RID: 4825
		private IExtension extensionObject;

		// Token: 0x040012DA RID: 4826
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040012DB RID: 4827
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040012DC RID: 4828
		private LuaFunction m_ctor_hotfix;
	}
}
