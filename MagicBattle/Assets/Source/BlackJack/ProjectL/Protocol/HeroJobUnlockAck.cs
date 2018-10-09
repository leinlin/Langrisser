using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B4 RID: 1972
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroJobUnlockAck")]
	[Serializable]
	public class HeroJobUnlockAck : IExtensible
	{
		// Token: 0x0600651F RID: 25887 RVA: 0x001C4B40 File Offset: 0x001C2D40
		public HeroJobUnlockAck()
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

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x06006520 RID: 25888 RVA: 0x001C4BA8 File Offset: 0x001C2DA8
		// (set) Token: 0x06006521 RID: 25889 RVA: 0x001C4BB0 File Offset: 0x001C2DB0
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

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x06006522 RID: 25890 RVA: 0x001C4BBC File Offset: 0x001C2DBC
		// (set) Token: 0x06006523 RID: 25891 RVA: 0x001C4BC4 File Offset: 0x001C2DC4
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

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x001C4BD0 File Offset: 0x001C2DD0
		// (set) Token: 0x06006525 RID: 25893 RVA: 0x001C4BD8 File Offset: 0x001C2DD8
		[ProtoMember(3, IsRequired = true, Name = "JobRelateId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006526 RID: 25894 RVA: 0x001C4BE4 File Offset: 0x001C2DE4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x001C4BF4 File Offset: 0x001C2DF4
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

		// Token: 0x06006528 RID: 25896 RVA: 0x001C4CC0 File Offset: 0x001C2EC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobUnlockAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BC9 RID: 19401
		private int _Result;

		// Token: 0x04004BCA RID: 19402
		private int _HeroId;

		// Token: 0x04004BCB RID: 19403
		private int _JobRelateId;

		// Token: 0x04004BCC RID: 19404
		private IExtension extensionObject;

		// Token: 0x04004BCD RID: 19405
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BCE RID: 19406
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BCF RID: 19407
		private LuaFunction m_ctor_hotfix;
	}
}
