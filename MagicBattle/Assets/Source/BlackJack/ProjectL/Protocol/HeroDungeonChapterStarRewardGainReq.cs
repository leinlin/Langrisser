using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200079F RID: 1951
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroDungeonChapterStarRewardGainReq")]
	[Serializable]
	public class HeroDungeonChapterStarRewardGainReq : IExtensible
	{
		// Token: 0x0600645D RID: 25693 RVA: 0x001C23A0 File Offset: 0x001C05A0
		public HeroDungeonChapterStarRewardGainReq()
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

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600645E RID: 25694 RVA: 0x001C2408 File Offset: 0x001C0608
		// (set) Token: 0x0600645F RID: 25695 RVA: 0x001C2410 File Offset: 0x001C0610
		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get
			{
				return this._ChapterId;
			}
			set
			{
				this._ChapterId = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06006460 RID: 25696 RVA: 0x001C241C File Offset: 0x001C061C
		// (set) Token: 0x06006461 RID: 25697 RVA: 0x001C2424 File Offset: 0x001C0624
		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get
			{
				return this._Index;
			}
			set
			{
				this._Index = value;
			}
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x001C2430 File Offset: 0x001C0630
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x001C2440 File Offset: 0x001C0640
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

		// Token: 0x06006464 RID: 25700 RVA: 0x001C250C File Offset: 0x001C070C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonChapterStarRewardGainReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B3B RID: 19259
		private int _ChapterId;

		// Token: 0x04004B3C RID: 19260
		private int _Index;

		// Token: 0x04004B3D RID: 19261
		private IExtension extensionObject;

		// Token: 0x04004B3E RID: 19262
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B3F RID: 19263
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B40 RID: 19264
		private LuaFunction m_ctor_hotfix;
	}
}
