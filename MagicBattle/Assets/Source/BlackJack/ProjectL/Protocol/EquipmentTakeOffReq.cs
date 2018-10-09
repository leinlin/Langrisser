using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B9 RID: 1977
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EquipmentTakeOffReq")]
	[Serializable]
	public class EquipmentTakeOffReq : IExtensible
	{
		// Token: 0x06006549 RID: 25929 RVA: 0x001C5478 File Offset: 0x001C3678
		public EquipmentTakeOffReq()
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

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x001C54E0 File Offset: 0x001C36E0
		// (set) Token: 0x0600654B RID: 25931 RVA: 0x001C54E8 File Offset: 0x001C36E8
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600654C RID: 25932 RVA: 0x001C54F4 File Offset: 0x001C36F4
		// (set) Token: 0x0600654D RID: 25933 RVA: 0x001C54FC File Offset: 0x001C36FC
		[ProtoMember(2, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x001C5508 File Offset: 0x001C3708
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x001C5518 File Offset: 0x001C3718
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

		// Token: 0x06006550 RID: 25936 RVA: 0x001C55E4 File Offset: 0x001C37E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentTakeOffReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BE8 RID: 19432
		private int _HeroId;

		// Token: 0x04004BE9 RID: 19433
		private int _Slot;

		// Token: 0x04004BEA RID: 19434
		private IExtension extensionObject;

		// Token: 0x04004BEB RID: 19435
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BEC RID: 19436
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BED RID: 19437
		private LuaFunction m_ctor_hotfix;
	}
}
