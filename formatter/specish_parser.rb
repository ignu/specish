require "rexml/document"

include REXML

class SpecishParser

  attr_accessor :name, :concerns

  def load(filename)
     load_file(filename)
     get_name()
     get_concerns()
  end

  def load_file(filename)
      @file = Document.new(File.read(filename))
  end
  
  def get_name()
    XPath.each(@file, "//test-results") do |element|
      @name = element.attributes["name"].chomp(".dll")
    end
  end

  def get_concerns()
    @concerns = {}
    XPath.each(@file, "//test-results/test-suite/results/test-suite/results/test-suite") do |fixture_node|
        concern = get_concern(fixture_node.attributes["name"])
        if (!@concerns.has_key? concern.name)
          puts "adding concern " + concern.name
          @concerns[concern.name] = concern
        end
    end
  end
  
  def get_concern(fixture_name)
    Concern.new fixture_name.split("_")[0]
  end

  def get_context(fixture_name)
    @elements = fixture_name.split("_")
    @elements.shift()
    @elements.join(" ")
   end
  
end