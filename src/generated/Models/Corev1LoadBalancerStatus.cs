// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// LoadBalancerStatus represents the status of a load-balancer.
    /// </summary>
    public partial class Corev1LoadBalancerStatus
    {
        /// <summary>
        /// Initializes a new instance of the Corev1LoadBalancerStatus class.
        /// </summary>
        public Corev1LoadBalancerStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1LoadBalancerStatus class.
        /// </summary>
        /// <param name="ingress">Ingress is a list containing ingress points
        /// for the load-balancer. Traffic intended for the service should be
        /// sent to these ingress points.</param>
        public Corev1LoadBalancerStatus(IList<Corev1LoadBalancerIngress> ingress = default(IList<Corev1LoadBalancerIngress>))
        {
            Ingress = ingress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ingress is a list containing ingress points for the
        /// load-balancer. Traffic intended for the service should be sent to
        /// these ingress points.
        /// </summary>
        [JsonProperty(PropertyName = "ingress")]
        public IList<Corev1LoadBalancerIngress> Ingress { get; set; }

    }
}