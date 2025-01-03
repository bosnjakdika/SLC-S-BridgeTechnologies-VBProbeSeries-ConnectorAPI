﻿namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.Ethernet
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App Message allowing to add new entries to the Ethernet Available Streams table.
	/// </summary>
	public class CreateEthStream : Message
	{
		public EthStreamData StreamData { get; set; }
	}

	public class CreateEthStreamResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreateEthStream Request { get; set; }

		public string StreamKey { get; set; }

		public int StreamID { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to edit existing entries from the Ethernet Available Streams table.
	/// </summary>
	public class EditEthStream : Message
	{
		public string Key { get; set; }

		public EthStreamData StreamData { get; set; }
	}

	public class EditEthStreamResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditEthStream Request { get; set; }

		public string StreamKey { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to join/unjoin entries from the Ethernet Available Streams table.
	/// </summary>
	public class JoinUnjoinEthStreams : Message
	{
		public string[] StreamKeys { get; set; }

		public bool IsJoinMethod { get; set; }
	}

	public class JoinUnjoinEthStreamsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public string Description { get; set; }

		public JoinUnjoinEthStreams Request { get; set; }

		public List<string> ModifiedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}

	/// <summary>
	/// Inter-App Message allowing to delete existing entries from the Ethernet Available Streams table.
	/// </summary>
	public class DeleteEthStreams : Message
	{
		public string[] StreamKeys { get; set; }

		public bool DeleteAllOrNone { get; set; }
	}

	public class DeleteEthStreamsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllStreamsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteEthStreams Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
