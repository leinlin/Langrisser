using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B3 RID: 1971
	[ProtoContract(Name = "HeroJobUnlockReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroJobUnlockReq : IExtensible
	{
		// Token: 0x06006517 RID: 25879 RVA: 0x001C496C File Offset: 0x001C2B6C
		public HeroJobUnlockReq()
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

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x001C49D4 File Offset: 0x001C2BD4
		// (set) Token: 0x06006519 RID: 25881 RVA: 0x001C49DC File Offset: 0x001C2BDC
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

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x001C49E8 File Offset: 0x001C2BE8
		// (set) Token: 0x0600651B RID: 25883 RVA: 0x001C49F0 File Offset: 0x001C2BF0
		[ProtoMember(2, IsRequired = true, Name = "JobRelateId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelateId
		{
			get
			{
				return this._JobRelateId;
			}
			set
			{
				this._JobRelateId = value;
			}
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x001C49FC File Offset: 0x001C2BFC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x001C4A0C File Offset: 0x001C2C0C
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

		// Token: 0x0600651E RID: 25886 RVA: 0x001C4AD8 File Offset: 0x001C2CD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobUnlockReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BC3 RID: 19395
		private int _HeroId;

		// Token: 0x04004BC4 RID: 19396
		private int _JobRelateId;

		// Token: 0x04004BC5 RID: 19397
		private IExtension extensionObject;

		// Token: 0x04004BC6 RID: 19398
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BC7 RID: 19399
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BC8 RID: 19400
		private LuaFunction m_ctor_hotfix;
	}
}
