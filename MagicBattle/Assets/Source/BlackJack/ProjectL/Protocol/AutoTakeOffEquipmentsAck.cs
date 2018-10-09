using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D6 RID: 2006
	[ProtoContract(Name = "AutoTakeOffEquipmentsAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class AutoTakeOffEquipmentsAck : IExtensible
	{
		// Token: 0x0600665C RID: 26204 RVA: 0x001C8B34 File Offset: 0x001C6D34
		public AutoTakeOffEquipmentsAck()
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

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x001C8B9C File Offset: 0x001C6D9C
		// (set) Token: 0x0600665E RID: 26206 RVA: 0x001C8BA4 File Offset: 0x001C6DA4
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

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x001C8BB0 File Offset: 0x001C6DB0
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x001C8BB8 File Offset: 0x001C6DB8
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

		// Token: 0x06006661 RID: 26209 RVA: 0x001C8BC4 File Offset: 0x001C6DC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x001C8BD4 File Offset: 0x001C6DD4
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

		// Token: 0x06006663 RID: 26211 RVA: 0x001C8CA0 File Offset: 0x001C6EA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AutoTakeOffEquipmentsAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CAC RID: 19628
		private int _Result;

		// Token: 0x04004CAD RID: 19629
		private int _HeroId;

		// Token: 0x04004CAE RID: 19630
		private IExtension extensionObject;

		// Token: 0x04004CAF RID: 19631
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CB0 RID: 19632
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CB1 RID: 19633
		private LuaFunction m_ctor_hotfix;
	}
}
