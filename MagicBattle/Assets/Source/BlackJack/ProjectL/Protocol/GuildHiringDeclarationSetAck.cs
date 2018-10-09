using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000770 RID: 1904
	[ProtoContract(Name = "GuildHiringDeclarationSetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildHiringDeclarationSetAck : IExtensible
	{
		// Token: 0x060062E3 RID: 25315 RVA: 0x001BCD58 File Offset: 0x001BAF58
		public GuildHiringDeclarationSetAck()
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

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060062E4 RID: 25316 RVA: 0x001BCDC0 File Offset: 0x001BAFC0
		// (set) Token: 0x060062E5 RID: 25317 RVA: 0x001BCDC8 File Offset: 0x001BAFC8
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060062E6 RID: 25318 RVA: 0x001BCDD4 File Offset: 0x001BAFD4
		// (set) Token: 0x060062E7 RID: 25319 RVA: 0x001BCDDC File Offset: 0x001BAFDC
		[ProtoMember(2, IsRequired = true, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
		public string HiringDeclaration
		{
			get
			{
				return this._HiringDeclaration;
			}
			set
			{
				this._HiringDeclaration = value;
			}
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x001BCDE8 File Offset: 0x001BAFE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x001BCDF8 File Offset: 0x001BAFF8
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

		// Token: 0x060062EA RID: 25322 RVA: 0x001BCEC4 File Offset: 0x001BB0C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildHiringDeclarationSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A1C RID: 18972
		private int _Result;

		// Token: 0x04004A1D RID: 18973
		private string _HiringDeclaration;

		// Token: 0x04004A1E RID: 18974
		private IExtension extensionObject;

		// Token: 0x04004A1F RID: 18975
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A20 RID: 18976
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A21 RID: 18977
		private LuaFunction m_ctor_hotfix;
	}
}
