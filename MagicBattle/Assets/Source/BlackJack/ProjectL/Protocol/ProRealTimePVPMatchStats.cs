using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000696 RID: 1686
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRealTimePVPMatchStats")]
	[Serializable]
	public class ProRealTimePVPMatchStats : IExtensible
	{
		// Token: 0x06005B8B RID: 23435 RVA: 0x001A35B0 File Offset: 0x001A17B0
		public ProRealTimePVPMatchStats()
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

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x001A3618 File Offset: 0x001A1818
		// (set) Token: 0x06005B8D RID: 23437 RVA: 0x001A3620 File Offset: 0x001A1820
		[ProtoMember(1, IsRequired = true, Name = "Matches", DataFormat = DataFormat.TwosComplement)]
		public int Matches
		{
			get
			{
				return this._Matches;
			}
			set
			{
				this._Matches = value;
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x001A362C File Offset: 0x001A182C
		// (set) Token: 0x06005B8F RID: 23439 RVA: 0x001A3634 File Offset: 0x001A1834
		[ProtoMember(2, IsRequired = true, Name = "Wins", DataFormat = DataFormat.TwosComplement)]
		public int Wins
		{
			get
			{
				return this._Wins;
			}
			set
			{
				this._Wins = value;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x001A3640 File Offset: 0x001A1840
		// (set) Token: 0x06005B91 RID: 23441 RVA: 0x001A3648 File Offset: 0x001A1848
		[ProtoMember(3, IsRequired = true, Name = "ConsecutiveWins", DataFormat = DataFormat.TwosComplement)]
		public int ConsecutiveWins
		{
			get
			{
				return this._ConsecutiveWins;
			}
			set
			{
				this._ConsecutiveWins = value;
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x001A3654 File Offset: 0x001A1854
		// (set) Token: 0x06005B93 RID: 23443 RVA: 0x001A365C File Offset: 0x001A185C
		[ProtoMember(4, IsRequired = true, Name = "ConsecutiveLosses", DataFormat = DataFormat.TwosComplement)]
		public int ConsecutiveLosses
		{
			get
			{
				return this._ConsecutiveLosses;
			}
			set
			{
				this._ConsecutiveLosses = value;
			}
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x001A3668 File Offset: 0x001A1868
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x001A3678 File Offset: 0x001A1878
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

		// Token: 0x06005B96 RID: 23446 RVA: 0x001A3744 File Offset: 0x001A1944
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRealTimePVPMatchStats));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400448B RID: 17547
		private int _Matches;

		// Token: 0x0400448C RID: 17548
		private int _Wins;

		// Token: 0x0400448D RID: 17549
		private int _ConsecutiveWins;

		// Token: 0x0400448E RID: 17550
		private int _ConsecutiveLosses;

		// Token: 0x0400448F RID: 17551
		private IExtension extensionObject;

		// Token: 0x04004490 RID: 17552
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004491 RID: 17553
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004492 RID: 17554
		private LuaFunction m_ctor_hotfix;
	}
}
