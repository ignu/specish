require "spec"
require "../specish_parser.rb"

describe SpecishParser, "when parsing a valid test fixture name" do

  parser = SpecishParser.new
  concern = parser.get_concern("HotDog_when_eating_one")
  context = parser.get_context("HotDog_when_eating_one")
  
  it "should be able to determine the concern" do
    #To change this template use File | Settings | File Templates.
    concern.name.should == "HotDog"
  end

   it "should be able to determine the context" do
    #To change this template use File | Settings | File Templates.
    context.should == "when eating one"
   end

end

describe SpecishParser, "when parsing a context" do

  parser = SpecishParser.new
  parser.name = "Example"
  concern = Concern.new("Player")

  value = "Example.Player_when_taking_damage.damage_minus_armor_buffer_is_subtracted_from_hitpoints"

  context = parser.get(concern, value)
  
  it "should be able to determine the observations" do
     context.should == "when taking damage"   
  end
end

describe SpecishParser, "when parsing nunit results file" do

  parser = SpecishParser.new

  it "should be able to determine the name" do
    parser.load "console-test.xml"    
    parser.name.should == "Example"
  end

  it "should load the concerns" do
    parser.concerns.length.should == 1
  end

  it "should load the concerns contexts" do
    parser.concerns.shift[1].contexts.length.should > 0
  end

  it "should load the contexts results" do
    parser.concerns.shift[1]
  end

end
