using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCareerGuidanceMIS
{
    public partial class FrmAboutCareer : Form
    {
        private Student student;
        private string strCareer;
        private int countConstructor;
        public FrmAboutCareer(Student stdt)
        {
            InitializeComponent();
            student = stdt;
            countConstructor = 1;
        }

        public FrmAboutCareer(string careerSearch)
        {
            InitializeComponent();
            strCareer = careerSearch;
            countConstructor = 2;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAboutCareer_Load(object sender, EventArgs e)
        {
            if (countConstructor == 1)
                lblCareer.Text = student.StudentCareer;
            else if (countConstructor == 2)
                lblCareer.Text = strCareer;
            loadBriefIntroduction();
            //set career courses for science students
            if ((lblCareer.Text == "Industrial Chemistry") || (lblCareer.Text == "Food Science Technology") || (lblCareer.Text == "Science Laboratory Technology"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Physics, Biology or Economics";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, FUTMINNA, FUNAAB, FUTA, OSPOLY, OSCOTECH, and others";
            }
            else if ((lblCareer.Text == "Medicine") || (lblCareer.Text == "Pharmacy") || (lblCareer.Text == "Biochemistry") || (lblCareer.Text == "Microbiology"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Physics, Biology or Agricultural Science";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, FUTMINNA, FUNAAB, UNIOSUN, UNIPORT, and others";
            }
            else if ((lblCareer.Text == "Computer Science") || (lblCareer.Text == "Library Information Science") || (lblCareer.Text == "Telecommunication Science") || (lblCareer.Text == "Information and Communication Science"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Physics, Biology or Computer Studies";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, UNILORIN, FUTMINNA, FUNAAB, FUTA, OSPOLY, OSCOTECH, and others";
            }
            else if ((lblCareer.Text == "Physics Electronics") || (lblCareer.Text == "Statistics") || (lblCareer.Text == "Industrial Mathematics"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Physics, Further Mathematics or Economics";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, FUTMINNA, FUNAAB, FUTA, OSPOLY, FEDPOFFA, and others";
            }
            //set career courses for Technical students
            else if ((lblCareer.Text == "Electrical and Electronic Engineering") || (lblCareer.Text == "Civil Engineering") || (lblCareer.Text == "Mechanical Engineering") || (lblCareer.Text == "Computer Engineering"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Physics, Technical Drawing or Further Mathematics";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, UNILORIN, FUTMINNA, FUNAAB, FUTA, OSPOLY, OSCOTECH, FEDPOEDE and others";
            }
            else if ((lblCareer.Text == "Agricultural Engineering") || (lblCareer.Text == "Petroleum Engineering") || (lblCareer.Text == "Mining Engineering") || (lblCareer.Text == "Material and Metallurgical Engineering"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Physics,  Technical Drawing or Further Mathematics";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, FUTMINNA, FUNAAB, FUTA, UNILORIN, UNIPORT, and others";
            }
            //set career courses for Commercial students
            else if ((lblCareer.Text == "Accountancy") || (lblCareer.Text == "Banking and Finance") || (lblCareer.Text == "Business Administration") || (lblCareer.Text == "Marketing"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Financial Accounting, Commerce, Economics or Government";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, UNILORIN, FUNAAB,  OSPOLY, OSCOTECH, and others";
            }
            else if ((lblCareer.Text == "Business Studies") || (lblCareer.Text == "Secretariat Studies"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Financial Accounting, Commerce, Book Keeping or Shorthand";
                lblHigherInstitutions.Text = "UI, OAU, FEDPOBIDA, UNILORIN, FUNAAB, KWAPOLY, OSPOLY, OSCOTECH, and others";
            }
            //set career courses for Social Science and Arts students
            else if ((lblCareer.Text == "Mass Communication") || (lblCareer.Text == "Law") || (lblCareer.Text == "Psychology"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Literature in English, History, Economics or Government";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, FUTMINNA, FUNAAB, UNILORIN, EKSU, and others";
                
            }
            else if ((lblCareer.Text == "Architecture") || (lblCareer.Text == "Estate Management") || (lblCareer.Text == "Quantity Surveying") || (lblCareer.Text == "Building Technology") || (lblCareer.Text == "Urban and Regional Planning") || (lblCareer.Text == "Industrial Design"))
            {
                lblBasicRequirements.Text = lblBasicRequirements.Text + "Chemistry, Geography, Economics or Government";
                lblHigherInstitutions.Text = "UI, OAU, UNIBEN, FUTMINNA, FUNAAB, FUTA, OSPOLY, OSCOTECH, and others";
            }
        }

        private void loadBriefIntroduction()
        {
            if (lblCareer.Text == "Industrial Chemistry")
                txtCareerIntroduction.Text = "Industrial Chemistry, study of the composition, structure, properties, and interactions of matter. Chemistry arose from attempts by people to transform metals into gold beginning about ad 100, an effort that became known as alchemy (see Chemistry, History of). Modern chemistry was established in the late 18th century, as scientists began identifying and verifying through scientific experimentation the elemental processes and interactions that create the gases, liquids, and solids that compose our physical world. As the field of chemistry developed in the 19th and 20th centuries, chemists learned how to create new substances that have many important applications in our lives.";
            else if (lblCareer.Text == "Food Science Technology")
                txtCareerIntroduction.Text = "Food Science Technology, study of science and technology used in Food Processing and Preservation, branch of manufacturing that transforms raw animal, vegetable, or marine materials into tasty, nutritious, and safe food products. The industry has its roots in ancient times, as humans have always needed to obtain food and store a portion for later use. Prehistoric humans may have dried fruits in the sun and stored meat in cold areas, such as caves. The modern food processing and preservation industry was born in 1809, when French chef and inventor Nicolas Appert, searching for a better way to provide food for Napoleon’s army, devised a method for sterilizing food in tightly sealed glass bottles.";
            else if (lblCareer.Text == "Science Laboratory Technology")
                txtCareerIntroduction.Text = "Science Laboratory Technology, with a science background and the desire to support analysis, investigation, research and development, you could work as a scientific laboratory technician. As a scientific laboratory technician, you will be involved in a variety of laboratory-based investigations within biological, chemical, physical, and life science areas.\r\nYou may carry out sampling, testing, measuring, recording and analysing of results as parts of a scientific team. Your job is to provide all the required technical support to enable the laboratory to function effectively, while adhering to correct procedures and health and safety guidelines.";
            else if (lblCareer.Text == "Medicine")
                txtCareerIntroduction.Text = "Medicine (Latin medicus, “physician”), the science and art of diagnosing, treating, and preventing disease and injury. Its goals are to help people live longer, happier, more active lives with less suffering and disability. Medicine goes beyond the bedside of patients. Medical scientists engage in a constant search for new drugs, effective treatments, and more advanced technology. In addition, medicine is a business. It is part of the health care industry, one of the largest industries in the United States, and among the leading employers in most communities.";
            else if (lblCareer.Text == "Pharmacy")
                txtCareerIntroduction.Text = "Pharmacy, practice of compounding and dispensing drugs and providing drug-related information to consumers; also the place where such medicinal products are prepared. Pharmacy is an area of materia medica, that branch of medical science concerning the sources, nature, properties, and preparation of drugs. Pharmacists share with the chemical and medical profession responsibility for discovering new drugs and synthesizing organic compounds of therapeutic value. In addition, the community pharmacist, or druggist, is increasingly called upon to give advice in matters of health and hygiene.";
            else if (lblCareer.Text == "Biochemistry")
                txtCareerIntroduction.Text = "Biochemistry, study of the substances found in living organisms, and of the chemical reactions underlying life processes. This science is a branch of both chemistry and biology; the prefix bio- comes from bios, the Greek word for “life.” The chief goal of biochemistry is to understand the structure and behavior of biomolecules. These are the carbon-containing compounds that make up the various parts of the living cell and carry out the chemical reactions that enable it to grow, maintain and reproduce itself, and use and store energy.";
            else if (lblCareer.Text == "Microbiology")
                txtCareerIntroduction.Text = "Microbiology, study of microscopic organisms or microbes. Microbiology involves many fields of science in biology and medicine. Microbiology began in the 19th century as bacteriology, the study of bacteria. The French scientist Louis Pasteur is considered the founder of microbiology. Modern microbiology includes other microorganisms such as archaea, protozoa, algae, fungi, viruses, and microscopic parasites. Microbiologists use tools from genetics and biochemistry, as well as microscopes and other technology. Areas of research include the structures, functions, chemistry, evolution, and ecology of microorganisms, as well as their disease-causing or beneficial properties and effects. Microbiology has applications in medicine, chemistry, industry, biotechnology, agriculture, and food production.";
            else if (lblCareer.Text == "Computer Science")
                txtCareerIntroduction.Text = "Computer Science, study of the theory, experimentation, and engineering that form the basis for the design and use of computers—devices that automatically process information. Computer science traces its roots to work done by English mathematician Charles Babbage, who first proposed a programmable mechanical calculator in 1837. Until the advent of electronic digital computers in the 1940s, computer science was not generally distinguished as being separate from mathematics and engineering. Since then it has sprouted numerous branches of research that are unique to the discipline.\n\rMajor fields in Computer Science include: Software Development, Artificial Intelligence, Networking, Web Designing, Web Development, Graphic Design, System Analyst, Programming, etc.";
            else if (lblCareer.Text == "Library Information Science")
                txtCareerIntroduction.Text = "Library Information Science, The Association for Library and Information Science Education (ALISE), founded in 1915, is the professional association for faculty members in schools of library and information science. Its purpose is to promote excellence in education for library and information science. The ALISE maintains headquarters in Arlington, Virginia.";
            else if (lblCareer.Text == "Telecommunication Science")
                txtCareerIntroduction.Text = "Telecommunication Science,the study of devices and systems that transmit electronic or optical signals across long distances. Telecommunications enables people around the world to contact one another, to access information instantly, and to communicate from remote areas. Telecommunications usually involves a sender of information and one or more recipients linked by a technology, such as a telephone system, that transmits information from one place to another. Telecommunications enables people to send and receive personal messages across town, between countries, and to and from outer space. It also provides the key medium for delivering news, data, information, and entertainment.";
            else if (lblCareer.Text == "Information and Communication Science")
                txtCareerIntroduction.Text = "Information and Communication Science, the study of the process of sharing ideas, information, and messages with others in a particular time and place. Communication includes writing and talking, as well as nonverbal communication (such as facial expressions, body language, or gestures), visual communication (the use of images or pictures, such as painting, photography, video, or film), and electronic communication (telephone calls, electronic mail, cable television, or satellite broadcasts). Communication is a vital part of personal life and is also important in business, education, and any other situation where people encounter each other.";
            else if (lblCareer.Text == "Physics Electronics")
                txtCareerIntroduction.Text = "Physics Electronics, major science, dealing with the fundamental constituents of the universe, the forces they exert on one another, and the results produced by these forces. Sometimes in modern physics a more sophisticated approach is taken that incorporates elements of the three areas listed above; it relates to the laws of symmetry and conservation, such as those pertaining to energy, momentum, charge, and parity. See Atom; Energy.";
            else if (lblCareer.Text == "Statistics")
                txtCareerIntroduction.Text = "Statistics, branch of mathematics that deals with the collection, organization, and analysis of numerical data and with such problems as experiment design and decision making.";
            else if (lblCareer.Text == "Industrial Mathematics")
                txtCareerIntroduction.Text = "Industrial Mathematics, a way of describing relationships between numbers and other measurable quantities. Mathematics can express simple equations as well as interactions among the smallest particles and the farthest objects in the known universe. Mathematics allows scientists to communicate ideas using universally accepted terminology. It is truly the language of science.";
            else if (lblCareer.Text == "Electrical and Electronic Engineering")
                txtCareerIntroduction.Text = "Electrical and Electronic Engineering, The largest and most diverse field of engineering, it is concerned with the development and design, application, and manufacture of systems and devices that use electric power and signals. Among the most important subjects in the field in the late 1980s are electric power and machinery, electronic circuits, control systems, computer design, superconductors, solid-state electronics, medical imaging systems, robotics, lasers, radar, consumer electronics, and fiber optics.";
            else if (lblCareer.Text == "Civil Engineering")
                txtCareerIntroduction.Text = "Civil Engineering, is perhaps the broadest of the engineering fields, for it deals with the creation, improvement, and protection of the communal environment, providing facilities for living, industry and transportation, including large buildings, roads, bridges, canals, railroad lines, airports, water-supply systems, dams, irrigation, harbors, docks, aqueducts, tunnels, and other engineered constructions. The civil engineer must have a thorough knowledge of all types of surveying, of the properties and mechanics of construction materials, the mechanics of structures and soils, and of hydraulics and fluid mechanics. Among the important subdivisions of the field are construction engineering, irrigation engineering, transportation engineering, soils and foundation engineering, geodetic engineering, hydraulic engineering, and coastal and ocean engineering.";
            else if (lblCareer.Text == "Mechanical Engineering")
                txtCareerIntroduction.Text = "Mechanical Engineering, Engineers in this field design, test, build, and operate machinery of all types; they also work on a variety of manufactured goods and certain kinds of structures. The field is divided into (1) machinery, mechanisms, materials, hydraulics, and pneumatics; and (2) heat as applied to engines, work and energy, heating, ventilating, and air conditioning. The mechanical engineer, therefore, must be trained in mechanics, hydraulics, and thermodynamics and must be fully grounded in such subjects as metallurgy and machine design. Some mechanical engineers specialize in particular types of machines such as pumps or steam turbines. A mechanical engineer designs not only the machines that make products but the products themselves, and must design for both economy and efficiency. A typical example of the complexity of modern mechanical engineering is the design of an automobile, which entails not only the design of the engine that drives the car but also all its attendant accessories such as the steering and braking systems, the lighting system, the gearing by which the engine's power is delivered to the wheels, the controls, and the body, including such details as the door latches and the type of seat upholstery.";
            else if (lblCareer.Text == "Computer Engineering")
                txtCareerIntroduction.Text = "Computer Engineering, Virtually unknown just a few decades ago, computer engineering is now among the most rapidly growing fields. The electronics of computers involve engineers in design and manufacture of memory systems, of central processing units, and of peripheral devices (see Computer). Foremost among the avenues now being pursued are the design of Very Large Scale Integration (VLSI) and new computer architectures. The field of computer science is closely related to computer engineering; however, the task of making computers more “intelligent” (artificial intelligence,), through creation of sophisticated programs or development of higher level machine languages or other means, is generally regarded as being in the realm of computer science.";
            else if (lblCareer.Text == "Agricultural Engineering")
                txtCareerIntroduction.Text = "Agricultural Engineering, Modern agriculture depends heavily on engineering and technology and on the biological and physical sciences. Irrigation, drainage, conservation, and sanitary engineering—each of which is important in successful farming—are some of the fields requiring the specialized knowledge of agricultural engineers.";
            else if (lblCareer.Text == "Petroleum Engineering")
                txtCareerIntroduction.Text = "Petroleum Engineering, the disciplines employed by exploration and petroleum engineers are drawn from virtually every field of science and engineering. Thus the exploration staffs include geologists who specialize in surface mapping in order to try to reconstruct the subsurface configuration of the various sedimentary strata that will afford clues to the presence of petroleum traps. Subsurface specialists then study drill cuttings and interpret data on the subsurface formations that is relayed to surface recorders from electrical, sonic, and nuclear logging devices lowered into the bore hole on a wire line. Seismologists interpret sophisticated signals returning to the surface from sound waves that are propagated through Earth’s crust. Geochemists study the transformation of organic matter and the means for detecting and predicting the occurrence of such matter in subsurface strata. In addition, physicists, chemists, biologists, and mathematicians all support the basic research and development of sophisticated exploration techniques.";
            else if (lblCareer.Text == "Mining Engineering")
                txtCareerIntroduction.Text = "Mining Engineering, this branch of engineering includes activities related to the discovery and exploration of mineral deposits and the financing, construction, development, operation, recovery, processing, purification, and marketing of crude minerals and mineral products. The mining engineer is trained in historical geology, mineralogy, paleontology, and geophysics, and employs such tools as the seismograph and the magnetometer for the location of ore or petroleum deposits beneath the surface of the earth (see Petroleum; Seismology). The surveying and drawing of geological maps and sections is an important part of the work of the engineering geologist, who is also responsible for determining whether the geological structure of a given location is suitable for the building of such large structures as dams.";
            else if (lblCareer.Text == "Material and Metallurgical Engineering")
                txtCareerIntroduction.Text = "Material and Metallurgical Engineering, the study of materials, nonmetallic as well as metallic, and how they can be adapted and fabricated to meet the needs of modern technology. Using the laboratory techniques and research tools of physics, chemistry, and metallurgy, scientists are finding new ways of using plastics, ceramics, and other nonmetals in applications formerly reserved for metals.";
            else if (lblCareer.Text == "Accountancy")
                txtCareerIntroduction.Text = "Accountancy, the work or profession of an accountant, which involves the process of identifying, measuring, recording, and communicating economic information about an organization or other entity, in order to permit informed judgments by users of the information. Bookkeeping encompasses the record-keeping aspect of accounting and therefore provides much of the data to which accounting principles are applied in the preparation of financial statements and other financial information.";
            else if (lblCareer.Text == "Banking and Finance")
                txtCareerIntroduction.Text = "Banking and Finance, the business of providing financial services to consumers and businesses. The basic services a bank provides are checking accounts, which can be used like money to make payments and purchase goods and services; savings accounts and time deposits that can be used to save money for future use; loans that consumers and businesses can use to purchase goods and services; and basic cash management services such as check cashing and foreign currency exchange. Four types of banks specialize in offering these basic banking services: commercial banks, savings and loan associations, savings banks, and credit unions.";
            else if (lblCareer.Text == "Business Administration")
                txtCareerIntroduction.Text = "Business Administration, the work or profession of a business administrator which deals with Industrial Management, in business, term used to describe the techniques and expertise of efficient organization, planning, direction, and control of the operations of a business.";
            else if (lblCareer.Text == "Marketing")
                txtCareerIntroduction.Text = "Marketing, the process by which a product or service originates and is then priced, promoted, and distributed to consumers. In large corporations the principal marketing functions precede the manufacture of a product. They involve market research and product development, design, and testing.";
            else if (lblCareer.Text == "Business Studies")
                txtCareerIntroduction.Text = "Business Studies, instruction in running a business: the study of the activities involved in running a business, especially the financial and managerial aspects.";
            else if (lblCareer.Text == "Secretariat Studies")
                txtCareerIntroduction.Text = "Secretariat Studies, \n\rclerical worker: an employee who does clerical and administrative work in an office for a person or organization. \r\nofficer of organization: somebody elected or appointed to keep the records of the meetings of an organization such as a club, society, or committee, and to write or answer letters on its behalf, Secretary: U.S. cabinet member: a cabinet-level official of a national government.";
            else if (lblCareer.Text == "Mass Communication")
                txtCareerIntroduction.Text = "Mass Communication, communication by mass media: communication by means of broadcasting and newspapers, which reaches all or most people in society.\n\rRadio and Television Broadcasting, primary means by which information and entertainment are delivered to the public in virtually every nation around the world. The term broadcasting refers to the airborne transmission of electromagnetic audio signals (radio) or audiovisual signals (television) that are accessible to a wide population via standard, readily available receivers. The term has its origins in the medieval agricultural practice of “broadcasting,” which refers to planting seeds by scattering them across a field.";
            else if (lblCareer.Text == "Law")
                txtCareerIntroduction.Text = "Law, body of official rules and regulations, generally found in constitutions, legislation, judicial opinions, and the like, that is used to govern a society and to control the behavior of its members. The nature and functions of law have varied throughout history. In modern societies, some authorized body such as a legislature or a court makes the law. It is backed by the coercive power of the state, which enforces the law by means of appropriate penalties or remedies.";
            else if (lblCareer.Text == "Psychology")
                txtCareerIntroduction.Text = "Psychology, the scientific study of behavior and the mind. This definition contains three elements. The first is that psychology is a scientific enterprise that obtains knowledge through systematic and objective methods of observation and experimentation. Second is that psychologists study behavior, which refers to any action or reaction that can be measured or observed—such as the blink of an eye, an increase in heart rate, or the unruly violence that often erupts in a mob. Third is that psychologists study the mind, which refers to both conscious and unconscious mental states. These states cannot actually be seen, only inferred from observable behavior.";
            else if (lblCareer.Text == "Architecture")
                txtCareerIntroduction.Text = "Architecture (building), the practice of building design and its resulting products; customary usage refers only to those designs and structures that are culturally significant. Architecture is to building as literature is to the printed word. Vitruvius, a 1st-century bc Roman, wrote encyclopedically about architecture, and the English poet Sir Henry Wotton was quoting him in his charmingly phrased dictum: “Well building hath three conditions: Commoditie, Firmenes, and Delight.” More prosaically, one would say today that architecture must satisfy its intended uses, must be technically sound, and must convey aesthetic meaning. But the best buildings are often so well constructed that they outlast their original use. They then survive not only as beautiful objects, but as documents of the history of cultures, achievements in architecture that testify to the nature of the society that produced them. These achievements are never wholly the work of individuals. Architecture is a social art.";
            else if (lblCareer.Text == "Estate Management")
                txtCareerIntroduction.Text = "Estate Management, the study that deals with the management of Estate, in law, the degree of interest or ownership that a person has in property. The term estate is also used in a more general sense to denote the whole property possessed by an individual, for example, the estate of a deceased person. Sometimes debts are also included in this wide meaning, with all rights and duties regarded as a single entity. Estate in this sense of “the total belongings of a person” is divided into realty, or real estate, and personal estate.\n\rReal Estate, in broad definition, land and everything made permanently a part thereof, and the nature and extent of one's interest therein. In law, the word real, as it relates to property, means land as distinguished from personal property; and estate is defined as the interest one has in property.";
            else if (lblCareer.Text == "Quantity Surveying")
                txtCareerIntroduction.Text = "Quantity Surveying, the basis of a modern map is a careful survey giving geographical locations and relations of a large number of points in the area being mapped. Today, nearly all original maps make use of aerial photographs in addition to traditional land-surveying information (see Aerial Survey; Surveying). Satellite photographs can furnish a wealth of accurate information about various features on the earth's surface, including the location of mineral deposits, the extent of urban sprawl, vegetation infestations, and soil types.";
            else if (lblCareer.Text == "Building Technology")
                txtCareerIntroduction.Text = "Building Technology, the study of procedures involved in the erection of various types of structures. The major trend in present-day construction continues away from handcrafting at the building site and toward on-site assembly of ever larger, more integrated subassemblies manufactured away from the site. Another characteristic of contemporary building, related to the latter trend, is the greater amount of dimensional coordination; that is, buildings are designed and components manufactured in multiples of a standard module (10 cm/4 in being standard in the U.S.), which drastically reduces the amount of cutting and fitting required on the building site. A third trend is the production or redevelopment of such large structural complexes as shopping centers, entire campuses, and whole towns or sections of cities.";
            else if (lblCareer.Text == "Urban and Regional Planning")
                txtCareerIntroduction.Text = "Urban and Regional Planning, the unified development of cities and their environs. For most of its history, city planning dealt primarily with the regulation of land use and the physical arrangement of city structures, as guided by architectural, engineering, and land-development criteria. In the mid-20th century it broadened to include the comprehensive guidance of the physical, economic, and social environment of a community. Elements characteristic of city planning include (1) general plans that summarize the objectives of (and restraints on) land development; (2) zoning and subdivision controls that specify permissible land uses, densities, and requirements for streets, utility services, and other improvements; (3) plans for traffic flow and public transportation; (4) strategies for economic revitalization of depressed urban and rural areas; (5) strategies for supportive action to help disadvantaged social groups; and (6) guidelines for environmental protection and preservation of scarce resources.";
            else if (lblCareer.Text == "Industrial Design")
                txtCareerIntroduction.Text = "Industrial Design, art and science involved in the creation of machine-made products. It is concerned with aesthetic appearance as well as with functional efficiency. The success of a design is measured by the profit it yields its manufacturer and the service and pleasure it affords its owner.";
        }
    }
}
 