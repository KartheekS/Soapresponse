

using System;
using System.Xml.Serialization;

namespace ConsoleApp35
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Envelope)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "target")]
	public class Target
	{

		[XmlElement(ElementName = "serviceName")]
		public string ServiceName { get; set; }

		[XmlElement(ElementName = "serviceOperation")]
		public string ServiceOperation { get; set; }
	}

	[XmlRoot(ElementName = "functionalContext")]
	public class FunctionalContext
	{

		[XmlElement(ElementName = "consumerName")]
		public string ConsumerName { get; set; }

		[XmlElement(ElementName = "target")]
		public Target Target { get; set; }
	}

	[XmlRoot(ElementName = "requestHeader")]
	public class RequestHeader
	{

		[XmlElement(ElementName = "serviceReferenceId")]
		public string ServiceReferenceId { get; set; }

		[XmlElement(ElementName = "functionalContext")]
		public FunctionalContext FunctionalContext { get; set; }
	}

	[XmlRoot(ElementName = "Header")]
	public class Header
	{

		[XmlElement(ElementName = "requestHeader")]
		public RequestHeader RequestHeader { get; set; }
	}

	[XmlRoot(ElementName = "invocationOutcome")]
	public class InvocationOutcome
	{

		[XmlElement(ElementName = "serviceReferenceId")]
		public string ServiceReferenceId { get; set; }

		[XmlElement(ElementName = "code")]
		public int Code { get; set; }

		[XmlElement(ElementName = "message")]
		public string Message { get; set; }
	}

	[XmlRoot(ElementName = "ServiceOrderDetail")]
	public class ServiceOrderDetail
	{

		[XmlElement(ElementName = "serviceCode")]
		public int ServiceCode { get; set; }

		[XmlElement(ElementName = "serviceDescription")]
		public string ServiceDescription { get; set; }

		[XmlElement(ElementName = "requestDate")]
		public DateTime RequestDate { get; set; }

		[XmlElement(ElementName = "source")]
		public string Source { get; set; }

		[XmlElement(ElementName = "requestStartDate")]
		public DateTime RequestStartDate { get; set; }

		[XmlElement(ElementName = "requestEndDate")]
		public DateTime RequestEndDate { get; set; }

		[XmlElement(ElementName = "serviceCodeExplanationDescription")]
		public string ServiceCodeExplanationDescription { get; set; }

		[XmlElement(ElementName = "requestUnits")]
		public int RequestUnits { get; set; }

		[XmlElement(ElementName = "unitType")]
		public string UnitType { get; set; }

		[XmlElement(ElementName = "requestedBedType")]
		public string RequestedBedType { get; set; }

		[XmlElement(ElementName = "infertilityFlag")]
		public bool InfertilityFlag { get; set; }

		[XmlElement(ElementName = "decisionServiceCode")]
		public int DecisionServiceCode { get; set; }

		[XmlElement(ElementName = "decisionServiceCodeDescription")]
		public string DecisionServiceCodeDescription { get; set; }

		[XmlElement(ElementName = "decisionDate")]
		public DateTime DecisionDate { get; set; }

		[XmlElement(ElementName = "decisionUnits")]
		public int DecisionUnits { get; set; }

		[XmlElement(ElementName = "decisionUnitType")]
		public string DecisionUnitType { get; set; }

		[XmlElement(ElementName = "decisionSetting")]
		public string DecisionSetting { get; set; }
	}

	[XmlRoot(ElementName = "serviceOrder")]
	public class ServiceOrder
	{

		[XmlElement(ElementName = "serviceOrderNumber")]
		public int ServiceOrderNumber { get; set; }

		[XmlElement(ElementName = "ServiceOrderDetail")]
		public ServiceOrderDetail ServiceOrderDetail { get; set; }
	}

	[XmlRoot(ElementName = "preCertification")]
	public class PreCertification
	{

		[XmlElement(ElementName = "preCertificationNumber")]
		public int PreCertificationNumber { get; set; }

		[XmlElement(ElementName = "serviceOrder")]
		public ServiceOrder ServiceOrder { get; set; }
	}

	[XmlRoot(ElementName = "locateServiceOrderDetailResponse")]
	public class LocateServiceOrderDetailResponse
	{

		[XmlElement(ElementName = "invocationOutcome")]
		public InvocationOutcome InvocationOutcome { get; set; }

		[XmlElement(ElementName = "preCertification")]
		public PreCertification PreCertification { get; set; }

		[XmlElement(ElementName = "locateServiceOrderDetailResponse")]
		public LocateServiceOrderDetailResponse locateServiceOrderDetailResponse { get; set; }
	}

	[XmlRoot(ElementName = "Body")]
	public class Body
	{

		[XmlElement(ElementName = "locateServiceOrderDetailResponse")]
		public LocateServiceOrderDetailResponse LocateServiceOrderDetailResponse { get; set; }
	}

	[XmlRoot(ElementName = "Envelope")]
	public class Envelope
	{

		[XmlElement(ElementName = "Header")]
		public Header Header { get; set; }

		[XmlElement(ElementName = "Body")]
		public Body Body { get; set; }
	}


}
