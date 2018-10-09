using System;
using System.Net;
using System.Threading;

namespace BlackJack.ProjectL.Static
{
	// Token: 0x020010FE RID: 4350
	internal class Hostname2Ip
	{
		// Token: 0x06015A3A RID: 88634 RVA: 0x00581F1C File Offset: 0x0058011C
		public Hostname2Ip(string hostname)
		{
			this.m_hostname = hostname;
			this.m_thread = new Thread(new ThreadStart(this.ThreadProc));
			this.m_thread.Start();
		}

		// Token: 0x06015A3B RID: 88635 RVA: 0x00581F50 File Offset: 0x00580150
		public void Destroy()
		{
			if (this.m_thread != null)
			{
				this.m_thread.Abort();
			}
			this.m_thread = null;
			this.m_isThreadExit = true;
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x06015A3C RID: 88636 RVA: 0x00581F78 File Offset: 0x00580178
		public bool isDone
		{
			get
			{
				return this.m_isThreadExit;
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x06015A3D RID: 88637 RVA: 0x00581F80 File Offset: 0x00580180
		public string ip
		{
			get
			{
				return this.m_ip;
			}
		}

		// Token: 0x06015A3E RID: 88638 RVA: 0x00581F88 File Offset: 0x00580188
		private void ThreadProc()
		{
			this.m_ip = this.Hostname2IP(this.m_hostname);
			this.m_thread = null;
			this.m_isThreadExit = true;
		}

		// Token: 0x06015A3F RID: 88639 RVA: 0x00581FAC File Offset: 0x005801AC
		private string Hostname2IP(string hostname)
		{
			string result;
			try
			{
				IPAddress ipaddress;
				if (IPAddress.TryParse(hostname, out ipaddress))
				{
					result = ipaddress.ToString();
				}
				else
				{
					result = Dns.GetHostEntry(hostname).AddressList[0].ToString();
				}
			}
			catch (Exception)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0400BD26 RID: 48422
		private Thread m_thread;

		// Token: 0x0400BD27 RID: 48423
		private bool m_isThreadExit;

		// Token: 0x0400BD28 RID: 48424
		private string m_ip;

		// Token: 0x0400BD29 RID: 48425
		private string m_hostname;
	}
}
