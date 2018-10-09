using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C0 RID: 1984
	[ProtoContract(Name = "HeroFetterLevelUpAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroFetterLevelUpAck : IExtensible
	{
		// Token: 0x06006586 RID: 25990 RVA: 0x001C6180 File Offset: 0x001C4380
		public HeroFetterLevelUpAck()
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

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x001C61E8 File Offset: 0x001C43E8
		// (set) Token: 0x06006588 RID: 25992 RVA: 0x001C61F0 File Offset: 0x001C43F0
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

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x001C61FC File Offset: 0x001C43FC
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x001C6204 File Offset: 0x001C4404
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x001C6210 File Offset: 0x001C4410
		// (set) Token: 0x0600658C RID: 25996 RVA: 0x001C6218 File Offset: 0x001C4418
		[ProtoMember(3, IsRequired = true, Name = "FetterId", DataFormat = DataFormat.TwosComplement)]
		public int FetterId
		{
			get
			{
				return this._FetterId;
			}
			set
			{
				this._FetterId = value;
			}
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x001C6224 File Offset: 0x001C4424
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x001C6234 File Offset: 0x001C4434
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

		// Token: 0x0600658F RID: 25999 RVA: 0x001C6300 File Offset: 0x001C4500
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFetterLevelUpAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C15 RID: 19477
		private int _Result;

		// Token: 0x04004C16 RID: 19478
		private int _HeroId;

		// Token: 0x04004C17 RID: 19479
		private int _FetterId;

		// Token: 0x04004C18 RID: 19480
		private IExtension extensionObject;

		// Token: 0x04004C19 RID: 19481
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C1A RID: 19482
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C1B RID: 19483
		private LuaFunction m_ctor_hotfix;
	}
}
